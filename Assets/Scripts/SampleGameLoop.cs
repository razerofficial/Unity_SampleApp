#define USE_ARRAY_EFFECTS

using ChromaSDK;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

using Device = ChromaSDK.ChromaAnimationAPI.Device;
using Device1D = ChromaSDK.ChromaAnimationAPI.Device1D;
using Device2D = ChromaSDK.ChromaAnimationAPI.Device2D;
using DeviceType = ChromaSDK.ChromaAnimationAPI.DeviceType;
using FChromaSDKDeviceFrameIndex = ChromaSDK.ChromaAnimationAPI.FChromaSDKDeviceFrameIndex;
using FChromaSDKScene = ChromaSDK.ChromaAnimationAPI.FChromaSDKScene;
using EChromaSDKSceneBlend = ChromaSDK.ChromaAnimationAPI.EChromaSDKSceneBlend;
using FChromaSDKSceneEffect = ChromaSDK.ChromaAnimationAPI.FChromaSDKSceneEffect;
using EChromaSDKSceneMode = ChromaSDK.ChromaAnimationAPI.EChromaSDKSceneMode;

public class SampleGameLoop : MonoBehaviour
{
    private bool _mInitialized = false;
    private int _mResult = 0;

    #region Streaming

    bool _mSupportsStreaming = false;
    byte _mPlatform = 0;

    string _mShortCode = ChromaSDK.Stream.Default.Shortcode;
    byte _mLenShortCode = 0;

    string _mStreamId = ChromaSDK.Stream.Default.StreamId;
    byte _mLenStreamId = 0;

    string _mStreamKey = ChromaSDK.Stream.Default.StreamKey;
    byte _mLenStreamKey = 0;

    string _mStreamFocus = ChromaSDK.Stream.Default.StreamFocus;
    byte _mLenStreamFocus = 0;
    string _mStreamFocusGuid = "UnitTest-" + Guid.NewGuid();

    public string GetShortcode()
    {
        if (_mLenShortCode == 0)
        {
            return "NOT_SET";
        }
        else
        {
            return _mShortCode;
        }
    }

    public string GetStreamId()
    {
        if (_mLenStreamId == 0)
        {
            return "NOT_SET";
        }
        else
        {
            return _mStreamId;
        }
    }

    public string GetStreamKey()
    {
        if (_mLenStreamKey == 0)
        {
            return "NOT_SET";
        }
        else
        {
            return _mStreamKey;
        }
    }

    public string GetStreamFocus()
    {
        if (_mLenStreamFocus == 0)
        {
            return "NOT_SET";
        }
        else
        {
            return _mStreamFocus;
        }
    }

    #endregion

    private bool _mWaitForExit = true;
    private Thread _mThread = null;
    private bool _mHotkeys = true;
    private bool _mAmmo = true;
    private bool _mExtended = true;
    private int _mAmbientColor = 0;
    private int _mIndexGradient1 = -1;
    private int _mIndexGradient2 = -1;
    private int _mIndexGradient3 = -1;
    private int _mIndexGradient4 = -1;
    private int _mTimeMS = 0;

#if !USE_ARRAY_EFFECTS

    // This final animation will have a single frame
    // Any color changes will immediately display in the next frame update.
    string ANIMATION_FINAL_CHROMA_LINK = "Dynamic\\Final_ChromaLink.chroma";
    string ANIMATION_FINAL_HEADSET = "Dynamic\\Final_Headset.chroma";
    string ANIMATION_FINAL_KEYBOARD = "Dynamic\\Final_Keyboard.chroma";
    string ANIMATION_FINAL_KEYBOARD_EXTENDED = "Dynamic\\Final_KeyboardExtended.chroma";
    string ANIMATION_FINAL_KEYPAD = "Dynamic\\Final_Keypad.chroma";
    string ANIMATION_FINAL_MOUSE = "Dynamic\\Final_Mouse.chroma";
    string ANIMATION_FINAL_MOUSEPAD = "Dynamic\\Final_Mousepad.chroma";

#endif

    FChromaSDKScene _mScene = null;


    int HIBYTE(int a)
    {
        return (a & 0xFF00) >> 8;
    }

    int LOBYTE(int a)
    {
        return (a & 0x00FF);
    }


    int GetKeyColorIndex(int row, int column)
    {
        return ChromaAnimationAPI.GetMaxColumn(Device2D.Keyboard) * row + column;
    }

    void SetKeyColor(int[] colors, int rzkey, int color)
    {
        const int customFlag = 1 << 24;
        int row = HIBYTE(rzkey);
        int column = LOBYTE(rzkey);
        colors[GetKeyColorIndex(row, column)] = color | customFlag;
    }

    void SetKeyColorRGB(int[] colors, int rzkey, int red, int green, int blue)
    {
        SetKeyColor(colors, rzkey, ChromaAnimationAPI.GetRGB(red, green, blue));
    }

    int GetColorArraySize1D(Device1D device)
    {
        int maxLeds = ChromaAnimationAPI.GetMaxLeds(device);
        return maxLeds;
    }

    int GetColorArraySize2D(Device2D device)
    {
        int maxRow = ChromaAnimationAPI.GetMaxRow(device);
        int maxColumn = ChromaAnimationAPI.GetMaxColumn(device);
        return maxRow * maxColumn;
    }

#if !USE_ARRAY_EFFECTS

    void SetupAnimation1D(string path, Device1D device)
    {
        int animationId = ChromaAnimationAPI.GetAnimation(path);
        if (animationId == -1)
        {
            animationId = ChromaAnimationAPI.CreateAnimationInMemory((int)DeviceType.DE_1D, (int)device);
            ChromaAnimationAPI.CopyAnimation(animationId, path);
            ChromaAnimationAPI.CloseAnimation(animationId);
            ChromaAnimationAPI.MakeBlankFramesName(path, 1, 0.033f, 0);
        }
    }

    void SetupAnimation2D(string path, Device2D device)
    {
        int animationId = ChromaAnimationAPI.GetAnimation(path);
        if (animationId == -1)
        {
            animationId = ChromaAnimationAPI.CreateAnimationInMemory((int)DeviceType.DE_2D, (int)device);
            ChromaAnimationAPI.CopyAnimation(animationId, path);
            ChromaAnimationAPI.CloseAnimation(animationId);
            ChromaAnimationAPI.MakeBlankFramesName(path, 1, 0.033f, 0);
        }
    }

#endif

    void SetAmbientColor1D(Device1D device, int[] colors, int ambientColor)
    {
        int size = GetColorArraySize1D(device);
        for (int i = 0; i < size; ++i)
        {
            if (colors[i] == 0)
            {
                colors[i] = ambientColor;
            }
        }
    }

    void SetAmbientColor2D(Device2D device, int[] colors, int ambientColor)
    {
        int size = GetColorArraySize2D(device);
        for (int i = 0; i < size; ++i)
        {
            if (colors[i] == 0)
            {
                colors[i] = ambientColor;
            }
        }
    }

    void SetAmbientColor(int ambientColor,
        int[] colorsChromaLink,
        int[] colorsHeadset,
        int[] colorsKeyboard,
        int[] colorsKeypad,
        int[] colorsMouse,
        int[] colorsMousepad)
    {
        // Set ambient color
        for (int d = (int)Device.ChromaLink; d < (int)Device.MAX; ++d)
        {
            switch ((Device)d)
            {
                case Device.ChromaLink:
                    SetAmbientColor1D(Device1D.ChromaLink, colorsChromaLink, ambientColor);
                    break;
                case Device.Headset:
                    SetAmbientColor1D(Device1D.Headset, colorsHeadset, ambientColor);
                    break;
                case Device.Keyboard:
                    SetAmbientColor2D(Device2D.Keyboard, colorsKeyboard, ambientColor);
                    break;
                case Device.Keypad:
                    SetAmbientColor2D(Device2D.Keypad, colorsKeypad, ambientColor);
                    break;
                case Device.Mouse:
                    SetAmbientColor2D(Device2D.Mouse, colorsMouse, ambientColor);
                    break;
                case Device.Mousepad:
                    SetAmbientColor1D(Device1D.Mousepad, colorsMousepad, ambientColor);
                    break;
            }
        }
    }

    int MultiplyColor(int color1, int color2)
    {
        int redColor1 = color1 & 0xFF;
        int greenColor1 = (color1 >> 8) & 0xFF;
        int blueColor1 = (color1 >> 16) & 0xFF;

        int redColor2 = color2 & 0xFF;
        int greenColor2 = (color2 >> 8) & 0xFF;
        int blueColor2 = (color2 >> 16) & 0xFF;

        int red = (int)Mathf.Floor(255 * ((redColor1 / 255.0f) * (redColor2 / 255.0f)));
        int green = (int)Mathf.Floor(255 * ((greenColor1 / 255.0f) * (greenColor2 / 255.0f)));
        int blue = (int)Mathf.Floor(255 * ((blueColor1 / 255.0f) * (blueColor2 / 255.0f)));

        return ChromaAnimationAPI.GetRGB(red, green, blue);
    }

    int AverageColor(int color1, int color2)
    {
        return ChromaAnimationAPI.LerpColor(color1, color2, 0.5f);
    }

    int AddColor(int color1, int color2)
    {
        int redColor1 = color1 & 0xFF;
        int greenColor1 = (color1 >> 8) & 0xFF;
        int blueColor1 = (color1 >> 16) & 0xFF;

        int redColor2 = color2 & 0xFF;
        int greenColor2 = (color2 >> 8) & 0xFF;
        int blueColor2 = (color2 >> 16) & 0xFF;

        int red = Mathf.Min(redColor1 + redColor2, 255) & 0xFF;
        int green = Mathf.Min(greenColor1 + greenColor2, 255) & 0xFF;
        int blue = Mathf.Min(blueColor1 + blueColor2, 255) & 0xFF;

        return ChromaAnimationAPI.GetRGB(red, green, blue);
    }

    int SubtractColor(int color1, int color2)
    {
        int redColor1 = color1 & 0xFF;
        int greenColor1 = (color1 >> 8) & 0xFF;
        int blueColor1 = (color1 >> 16) & 0xFF;

        int redColor2 = color2 & 0xFF;
        int greenColor2 = (color2 >> 8) & 0xFF;
        int blueColor2 = (color2 >> 16) & 0xFF;

        int red = Mathf.Max(redColor1 - redColor2, 0) & 0xFF;
        int green = Mathf.Max(greenColor1 - greenColor2, 0) & 0xFF;
        int blue = Mathf.Max(blueColor1 - blueColor2, 0) & 0xFF;

        return ChromaAnimationAPI.GetRGB(red, green, blue);
    }

    int MaxColor(int color1, int color2)
    {
        int redColor1 = color1 & 0xFF;
        int greenColor1 = (color1 >> 8) & 0xFF;
        int blueColor1 = (color1 >> 16) & 0xFF;

        int redColor2 = color2 & 0xFF;
        int greenColor2 = (color2 >> 8) & 0xFF;
        int blueColor2 = (color2 >> 16) & 0xFF;

        int red = Mathf.Max(redColor1, redColor2) & 0xFF;
        int green = Mathf.Max(greenColor1, greenColor2) & 0xFF;
        int blue = Mathf.Max(blueColor1, blueColor2) & 0xFF;

        return ChromaAnimationAPI.GetRGB(red, green, blue);
    }

    int MinColor(int color1, int color2)
    {
        int redColor1 = color1 & 0xFF;
        int greenColor1 = (color1 >> 8) & 0xFF;
        int blueColor1 = (color1 >> 16) & 0xFF;

        int redColor2 = color2 & 0xFF;
        int greenColor2 = (color2 >> 8) & 0xFF;
        int blueColor2 = (color2 >> 16) & 0xFF;

        int red = Mathf.Min(redColor1, redColor2) & 0xFF;
        int green = Mathf.Min(greenColor1, greenColor2) & 0xFF;
        int blue = Mathf.Min(blueColor1, blueColor2) & 0xFF;

        return ChromaAnimationAPI.GetRGB(red, green, blue);
    }

    int InvertColor(int color)
    {
        int red = 255 - (color & 0xFF);
        int green = 255 - ((color >> 8) & 0xFF);
        int blue = 255 - ((color >> 16) & 0xFF);

        return ChromaAnimationAPI.GetRGB(red, green, blue);
    }

    int MultiplyNonZeroTargetColorLerp(int color1, int color2, int inputColor)
    {
        if (inputColor == 0)
        {
            return inputColor;
        }
        float red = (inputColor & 0xFF) / 255.0f;
        float green = ((inputColor & 0xFF00) >> 8) / 255.0f;
        float blue = ((inputColor & 0xFF0000) >> 16) / 255.0f;
        float t = (red + green + blue) / 3.0f;
        return ChromaAnimationAPI.LerpColor(color1, color2, t);
    }

    int Thresh(int color1, int color2, int inputColor)
    {
        float red = (inputColor & 0xFF) / 255.0f;
        float green = ((inputColor & 0xFF00) >> 8) / 255.0f;
        float blue = ((inputColor & 0xFF0000) >> 16) / 255.0f;
        float t = (red + green + blue) / 3.0f;
        if (t == 0.0)
        {
            return 0;
        }
        if (t < 0.5)
        {
            return color1;
        }
        else
        {
            return color2;
        }
    }


    void BlendAnimation1D(FChromaSDKSceneEffect effect, FChromaSDKDeviceFrameIndex deviceFrameIndex, int device, Device1D device1d, string animationName,
        int[] colors, int[] tempColors)
    {
        int size = GetColorArraySize1D(device1d);
        int frameId = deviceFrameIndex._mFrameIndex[device];
        int frameCount = ChromaAnimationAPI.GetFrameCountName(animationName);
        if (frameId < frameCount)
        {
            //cout << animationName << ": " << (1 + frameId) << " of " << frameCount << endl;
            float duration;
            ChromaAnimationAPI.GetFrameName(animationName, frameId, out duration, tempColors, size, null, 0);
            for (int i = 0; i < size; ++i)
            {
                int color1 = colors[i]; //target
                int tempColor = tempColors[i]; //source

                // BLEND
                int color2;
                switch (effect._mBlend)
                {
                    case EChromaSDKSceneBlend.SB_None:
                        color2 = tempColor; //source
                        break;
                    case EChromaSDKSceneBlend.SB_Invert:
                        if (tempColor != 0) //source
                        {
                            color2 = InvertColor(tempColor); //source inverted
                        }
                        else
                        {
                            color2 = 0;
                        }
                        break;
                    case EChromaSDKSceneBlend.SB_Threshold:
                        color2 = Thresh(effect._mPrimaryColor, effect._mSecondaryColor, tempColor); //source
                        break;
                    case EChromaSDKSceneBlend.SB_Lerp:
                    default:
                        color2 = MultiplyNonZeroTargetColorLerp(effect._mPrimaryColor, effect._mSecondaryColor, tempColor); //source
                        break;
                }

                // MODE
                switch (effect._mMode)
                {
                    case EChromaSDKSceneMode.SM_Max:
                        colors[i] = MaxColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Min:
                        colors[i] = MinColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Average:
                        colors[i] = AverageColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Multiply:
                        colors[i] = MultiplyColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Add:
                        colors[i] = AddColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Subtract:
                        colors[i] = SubtractColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Replace:
                    default:
                        if (color2 != 0)
                        {
                            colors[i] = color2;
                        }
                        break;
                }
            }
            deviceFrameIndex._mFrameIndex[device] = (frameId + frameCount + effect._mSpeed) % frameCount;
        }
    }

    void BlendAnimation2D(FChromaSDKSceneEffect effect, FChromaSDKDeviceFrameIndex deviceFrameIndex, int device, Device2D device2D, string animationName,
        int[] colors, int[] tempColors)
    {
        int size = GetColorArraySize2D(device2D);
        int frameId = deviceFrameIndex._mFrameIndex[device];
        int frameCount = ChromaAnimationAPI.GetFrameCountName(animationName);
        if (frameId < frameCount)
        {
            //cout << animationName << ": " << (1 + frameId) << " of " << frameCount << endl;
            float duration;
            ChromaAnimationAPI.GetFrameName(animationName, frameId, out duration, tempColors, size, null, 0);
            for (int i = 0; i < size; ++i)
            {
                int color1 = colors[i]; //target
                int tempColor = tempColors[i]; //source

                // BLEND
                int color2;
                switch (effect._mBlend)
                {
                    case EChromaSDKSceneBlend.SB_None:
                        color2 = tempColor; //source
                        break;
                    case EChromaSDKSceneBlend.SB_Invert:
                        if (tempColor != 0) //source
                        {
                            color2 = InvertColor(tempColor); //source inverted
                        }
                        else
                        {
                            color2 = 0;
                        }
                        break;
                    case EChromaSDKSceneBlend.SB_Threshold:
                        color2 = Thresh(effect._mPrimaryColor, effect._mSecondaryColor, tempColor); //source
                        break;
                    case EChromaSDKSceneBlend.SB_Lerp:
                    default:
                        color2 = MultiplyNonZeroTargetColorLerp(effect._mPrimaryColor, effect._mSecondaryColor, tempColor); //source
                        break;
                }

                // MODE
                switch (effect._mMode)
                {
                    case EChromaSDKSceneMode.SM_Max:
                        colors[i] = MaxColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Min:
                        colors[i] = MinColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Average:
                        colors[i] = AverageColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Multiply:
                        colors[i] = MultiplyColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Add:
                        colors[i] = AddColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Subtract:
                        colors[i] = SubtractColor(color1, color2);
                        break;
                    case EChromaSDKSceneMode.SM_Replace:
                    default:
                        if (color2 != 0)
                        {
                            colors[i] = color2;
                        }
                        break;
                }
            }
            deviceFrameIndex._mFrameIndex[device] = (frameId + frameCount + effect._mSpeed) % frameCount;
        }
    }

    void BlendAnimations(FChromaSDKScene scene,
        int[] colorsChromaLink, int[] tempColorsChromaLink,
        int[] colorsHeadset, int[] tempColorsHeadset,
        int[] colorsKeyboard, int[] tempColorsKeyboard,
        int[] colorsKeyboardExtended, int[] tempColorsKeyboardExtended,
        int[] colorsKeypad, int[] tempColorsKeypad,
        int[] colorsMouse, int[] tempColorsMouse,
        int[] colorsMousepad, int[] tempColorsMousepad)
    {
        // blend active animations
        List<FChromaSDKSceneEffect> effects = scene._mEffects;
        foreach (FChromaSDKSceneEffect effect in effects)
        {
            if (effect._mState)
            {
                FChromaSDKDeviceFrameIndex deviceFrameIndex = effect._mFrameIndex;

                //iterate all device types
                for (int d = (int)Device.ChromaLink; d < (int)Device.MAX; ++d)
                {
                    string animationName = effect._mAnimation;

                    switch ((Device)d)
                    {
                        case Device.ChromaLink:
                            animationName += "_ChromaLink.chroma";
                            BlendAnimation1D(effect, deviceFrameIndex, d, Device1D.ChromaLink, animationName, colorsChromaLink, tempColorsChromaLink);
                            break;
                        case Device.Headset:
                            animationName += "_Headset.chroma";
                            BlendAnimation1D(effect, deviceFrameIndex, d, Device1D.Headset, animationName, colorsHeadset, tempColorsHeadset);
                            break;
                        case Device.Keyboard:
                            animationName += "_Keyboard.chroma";
                            BlendAnimation2D(effect, deviceFrameIndex, d, Device2D.Keyboard, animationName, colorsKeyboard, tempColorsKeyboard);
                            break;
                        case Device.KeyboardExtended:
                            animationName += "_KeyboardExtended.chroma";
                            BlendAnimation2D(effect, deviceFrameIndex, d, Device2D.KeyboardExtended, animationName, colorsKeyboardExtended, tempColorsKeyboardExtended);
                            break;
                        case Device.Keypad:
                            animationName += "_Keypad.chroma";
                            BlendAnimation2D(effect, deviceFrameIndex, d, Device2D.Keypad, animationName, colorsKeypad, tempColorsKeypad);
                            break;
                        case Device.Mouse:
                            animationName += "_Mouse.chroma";
                            BlendAnimation2D(effect, deviceFrameIndex, d, Device2D.Mouse, animationName, colorsMouse, tempColorsMouse);
                            break;
                        case Device.Mousepad:
                            animationName += "_Mousepad.chroma";
                            BlendAnimation1D(effect, deviceFrameIndex, d, Device1D.Mousepad, animationName, colorsMousepad, tempColorsMousepad);
                            break;
                    }
                }
            }

        }
    }

    public void SetStaticColor(int[] colors, int color)
    {
        for (int i = 0; i < colors.Length; ++i)
        {
            colors[i] = color;
        }
    }

    #region Init/Uninit

    public IEnumerator Start()
    {
        if (!ChromaAnimationAPI.IsChromaSDKAvailable())
        {
            _mResult = RazerErrors.RZRESULT_DLL_NOT_FOUND;
            yield break;
        }

        ChromaAnimationAPI._sStreamingAssetPath = Application.streamingAssetsPath;

        ChromaSDK.APPINFOTYPE appInfo = new APPINFOTYPE();
        appInfo.Title = "Razer Chroma Unity Game Loop Sample Application";
        appInfo.Description = "A sample application using Razer Chroma SDK";

        appInfo.Author_Name = "Razer";
        appInfo.Author_Contact = "https://developer.razer.com/chroma";

        //appInfo.SupportedDevice = 
        //    0x01 | // Keyboards
        //    0x02 | // Mice
        //    0x04 | // Headset
        //    0x08 | // Mousepads
        //    0x10 | // Keypads
        //    0x20   // ChromaLink devices
        //    ;
        appInfo.SupportedDevice = (0x01 | 0x02 | 0x04 | 0x08 | 0x10 | 0x20);
        appInfo.Category = 1;
        _mResult = ChromaAnimationAPI.InitSDK(ref appInfo);
        switch (_mResult)
        {
            case RazerErrors.RZRESULT_DLL_NOT_FOUND:
                Debug.Log(string.Format("Chroma DLL is not found! {0}", RazerErrors.GetResultString(_mResult)));
                yield break;
            case RazerErrors.RZRESULT_DLL_INVALID_SIGNATURE:
                Debug.Log(string.Format("Chroma DLL has an invalid signature! {0}", RazerErrors.GetResultString(_mResult)));
                yield break;
            case RazerErrors.RZRESULT_SUCCESS:
                //Debug.Log("ChromaSDK initialized!");
                _mInitialized = true;
                _mSupportsStreaming = ChromaAnimationAPI.CoreStreamSupportsStreaming();
                yield return new WaitForSeconds(0.1f);
                break;
            default:
                // If Chroma is not supported on the system, just avoid making further calls to the API until next time
                Debug.Log(string.Format("Failed to initialize Chroma! {0}", RazerErrors.GetResultString(_mResult)));
                yield break;
        }

        // setup scene
        _mScene = new FChromaSDKScene();

        const int SPEED_MULTIPLIER = 3;

        FChromaSDKSceneEffect effect = new FChromaSDKSceneEffect();
        effect._mAnimation = "Animations/Gradient1";
        effect._mSpeed = SPEED_MULTIPLIER;
        effect._mBlend = EChromaSDKSceneBlend.SB_None;
        effect._mState = true;
        effect._mMode = EChromaSDKSceneMode.SM_Add;
        _mScene._mEffects.Add(effect);
        _mIndexGradient1 = (int)_mScene._mEffects.Count - 1;

        effect = new FChromaSDKSceneEffect();
        effect._mAnimation = "Animations/Gradient2";
        effect._mSpeed = SPEED_MULTIPLIER;
        effect._mBlend = EChromaSDKSceneBlend.SB_None;
        effect._mState = false;
        effect._mMode = EChromaSDKSceneMode.SM_Add;
        _mScene._mEffects.Add(effect);
        _mIndexGradient2 = (int)_mScene._mEffects.Count - 1;

        effect = new FChromaSDKSceneEffect();
        effect._mAnimation = "Animations/Gradient3";
        effect._mSpeed = SPEED_MULTIPLIER;
        effect._mBlend = EChromaSDKSceneBlend.SB_None;
        effect._mState = false;
        effect._mMode = EChromaSDKSceneMode.SM_Add;
        _mScene._mEffects.Add(effect);
        _mIndexGradient3 = (int)_mScene._mEffects.Count - 1;

        effect = new FChromaSDKSceneEffect();
        effect._mAnimation = "Animations/Gradient4";
        effect._mSpeed = SPEED_MULTIPLIER;
        effect._mBlend = EChromaSDKSceneBlend.SB_None;
        effect._mState = false;
        effect._mMode = EChromaSDKSceneMode.SM_Add;
        _mScene._mEffects.Add(effect);
        _mIndexGradient4 = (int)_mScene._mEffects.Count - 1;

        ThreadStart ts = new ThreadStart(GameLoop);
        _mThread = new Thread(ts);
        _mThread.Start();
    }
    void OnApplicationQuit()
    {
        _mWaitForExit = false;
        if (null != _mThread)
        {
            _mThread.Join();
            _mThread = null;
        }

        if (_mResult == RazerErrors.RZRESULT_SUCCESS)
        {
            ChromaAnimationAPI.StopAll();
            ChromaAnimationAPI.CloseAll();
            int result = ChromaAnimationAPI.Uninit();
#if !UNITY_EDITOR
            ChromaAnimationAPI.UninitAPI();
#endif
            if (result != RazerErrors.RZRESULT_SUCCESS)
            {
                Debug.LogError("Failed to uninitialize Chroma!");
            }
        }
    }

    #endregion

    private void OnGUI()
    {
        GUILayout.FlexibleSpace();
        GUILayout.BeginHorizontal(GUILayout.Width(Screen.width));
        GUILayout.FlexibleSpace();

        if (!_mInitialized)
        {
            GUILayout.BeginVertical(GUILayout.Height(Screen.height));
            GUILayout.FlexibleSpace();
            GUILayout.Label("Chroma SDK has not initialized or may not be present!");
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
        }
        else
        {
            switch (_mResult)
            {
                case RazerErrors.RZRESULT_DLL_NOT_FOUND:
                    GUILayout.BeginVertical(GUILayout.Height(Screen.height));
                    GUILayout.FlexibleSpace();
                    GUILayout.Label("Chroma DLL is not found!");
                    GUILayout.FlexibleSpace();
                    GUILayout.EndVertical();
                    break;
                case RazerErrors.RZRESULT_DLL_INVALID_SIGNATURE:
                    GUILayout.BeginVertical(GUILayout.Height(Screen.height));
                    GUILayout.FlexibleSpace();
                    GUILayout.Label("Chroma DLL has an invalid signature!");
                    GUILayout.FlexibleSpace();
                    GUILayout.EndVertical();
                    break;
                case RazerErrors.RZRESULT_SUCCESS:
                    {
                        const float buttonHeight = 40;

                        GUILayout.BeginHorizontal(GUILayout.Width(Screen.width), GUILayout.Height(Screen.height));
                        {
                            GUILayout.FlexibleSpace();
                            GUILayout.BeginVertical();
                            {
                                GUILayout.FlexibleSpace();

                                // horizontal center title
                                GUILayout.BeginHorizontal(GUILayout.Width(Screen.width));
                                {
                                    GUILayout.FlexibleSpace();
                                    GUILayout.Label("CHROMA GAME LOOP SAMPLE");
                                    GUILayout.FlexibleSpace();
                                }
                                GUILayout.EndHorizontal();

                                // center sections
                                GUILayout.BeginHorizontal(GUILayout.Width(Screen.width));
                                {
                                    GUILayout.FlexibleSpace();


                                    // streaming section
                                    GUILayout.BeginVertical(GUILayout.Width(300));
                                    {
                                        GUILayout.FlexibleSpace();

                                        #region Streaming

                                        if (_mSupportsStreaming)
                                        {
                                            GUILayout.Label("Streaming Info (SUPPORTED)");

                                            ChromaSDK.Stream.StreamStatusType status = ChromaAnimationAPI.CoreStreamGetStatus();
                                            GUILayout.Label(string.Format("Status: {0}", ChromaAnimationAPI.CoreStreamGetStatusString(status)));
                                            GUILayout.Label(string.Format("Shortcode: {0}", GetShortcode()));
                                            GUILayout.Label(string.Format("Stream Id: {0}", GetStreamId()));
                                            GUILayout.Label(string.Format("Stream Key: {0}", GetStreamKey()));
                                            GUILayout.Label(string.Format("Stream Focus: {0}", GetStreamFocus()));

                                            GUILayout.BeginHorizontal();
                                            {

                                                if (GUILayout.Button("Request Shortcode", GUILayout.Width(175), GUILayout.Height(buttonHeight)))
                                                {
                                                    _mShortCode = ChromaSDK.Stream.Default.Shortcode;
                                                    _mLenShortCode = 0;
                                                    string strPlatform = "PC";
                                                    switch (_mPlatform)
                                                    {
                                                        case 0:
                                                            strPlatform = "PC";
                                                            break;
                                                        case 1:
                                                            strPlatform = "LUNA";
                                                            break;
                                                        case 2:
                                                            strPlatform = "GEFORCE_NOW";
                                                            break;
                                                        case 3:
                                                            strPlatform = "GAME_PASS";
                                                            break;
                                                    }
                                                    ChromaAnimationAPI.CoreStreamGetAuthShortcode(ref _mShortCode, out _mLenShortCode, strPlatform, "Unity Game Loop Sample App 好");
                                                }

                                                GUILayout.BeginVertical();
                                                {
                                                    if (GUILayout.Button("Switch Platform"))
                                                    {
                                                        _mPlatform = (byte)((_mPlatform + 1) % 4); //PC, AMAZON LUNA, MS GAME PASS, NVIDIA GFN
                                                    }

                                                    string labelShortcode = "Platform: ";
                                                    switch (_mPlatform)
                                                    {
                                                        case 0:
                                                            labelShortcode += "Windows PC (PC)";
                                                            break;
                                                        case 1:
                                                            labelShortcode += "Windows Cloud (LUNA)";
                                                            break;
                                                        case 2:
                                                            labelShortcode += "Windows Cloud (GEFORCE NOW)";
                                                            break;
                                                        case 3:
                                                            labelShortcode += "Windows Cloud (GAME PASS)";
                                                            break;
                                                    }
                                                    GUILayout.Label(labelShortcode, GUILayout.Width(150));
                                                }
                                                GUILayout.EndVertical();
                                            }
                                            GUILayout.EndHorizontal();

                                            if (GUILayout.Button("Request StreamId", GUILayout.Width(175), GUILayout.Height(buttonHeight)))
                                            {
                                                _mStreamId = ChromaSDK.Stream.Default.StreamId;
                                                _mLenStreamId = 0;
                                                ChromaAnimationAPI.CoreStreamGetId(_mShortCode, ref _mStreamId, out _mLenStreamId);
                                                if (_mLenStreamId > 0)
                                                {
                                                    _mStreamId = _mStreamId.Substring(0, _mLenStreamId);
                                                }
                                            }

                                            if (GUILayout.Button("Request StreamKey", GUILayout.Width(175), GUILayout.Height(buttonHeight)))
                                            {
                                                _mStreamKey = ChromaSDK.Stream.Default.StreamKey;
                                                _mLenStreamKey = 0;
                                                ChromaAnimationAPI.CoreStreamGetKey(_mShortCode, ref _mStreamKey, out _mLenStreamKey);
                                                if (_mLenStreamId > 0)
                                                {
                                                    _mStreamKey = _mStreamKey.Substring(0, _mLenStreamKey);
                                                }
                                            }

                                            if (GUILayout.Button("Release Shortcode", GUILayout.Width(175), GUILayout.Height(buttonHeight)))
                                            {
                                                if (ChromaAnimationAPI.CoreStreamReleaseShortcode(_mShortCode))
                                                {
                                                    _mShortCode = ChromaSDK.Stream.Default.Shortcode;
                                                    _mLenShortCode = 0;
                                                }
                                            }

                                            if (GUILayout.Button("Broadcast", GUILayout.Width(175), GUILayout.Height(buttonHeight)))
                                            {
                                                if (_mLenStreamId > 0 && _mLenStreamKey > 0)
                                                {
                                                    ChromaAnimationAPI.CoreStreamBroadcast(_mStreamId, _mStreamKey);
                                                }
                                            }

                                            if (GUILayout.Button("BroadcastEnd", GUILayout.Width(175), GUILayout.Height(buttonHeight)))
                                            {
                                                ChromaAnimationAPI.CoreStreamBroadcastEnd();
                                            }

                                            if (GUILayout.Button("Watch", GUILayout.Width(175), GUILayout.Height(buttonHeight)))
                                            {
                                                if (_mLenStreamId > 0)
                                                {
                                                    ChromaAnimationAPI.CoreStreamWatch(_mStreamId, 0);
                                                }
                                            }

                                            if (GUILayout.Button("WatchEnd", GUILayout.Width(175), GUILayout.Height(buttonHeight)))
                                            {
                                                ChromaAnimationAPI.CoreStreamWatchEnd();
                                            }

                                            if (GUILayout.Button("GetFocus", GUILayout.Width(175), GUILayout.Height(buttonHeight)))
                                            {
                                                _mStreamFocus = ChromaSDK.Stream.Default.StreamFocus;
                                                _mLenStreamFocus = 0;
                                                ChromaAnimationAPI.CoreStreamGetFocus(ref _mStreamFocus, out _mLenStreamFocus);
                                            }

                                            if (GUILayout.Button("SetFocus", GUILayout.Width(175), GUILayout.Height(buttonHeight)))
                                            {
                                                ChromaAnimationAPI.CoreStreamSetFocus(_mStreamFocusGuid);

                                                _mStreamFocus = ChromaSDK.Stream.Default.StreamFocus;
                                                _mLenStreamFocus = 0;
                                                ChromaAnimationAPI.CoreStreamGetFocus(ref _mStreamFocus, out _mLenStreamFocus);
                                            }
                                        }

                                        #endregion

                                        GUILayout.FlexibleSpace();
                                    }
                                    GUILayout.EndVertical();

                                    GUILayout.FlexibleSpace();

                                    // sample section
                                    GUILayout.BeginVertical();
                                    {
                                        GUILayout.FlexibleSpace();

                                        _mHotkeys = GUILayout.Toggle(_mHotkeys, "Toggle Hotkeys");
                                        _mExtended = GUILayout.Toggle(_mExtended, "Extended Keyboard");
                                        _mAmmo = GUILayout.Toggle(_mAmmo, "Ammo/Health");
                                        if (_mIndexGradient1 >= 0)
                                        {
                                            _mScene._mEffects[_mIndexGradient1]._mState = GUILayout.Toggle(_mScene._mEffects[_mIndexGradient1]._mState, "Gradient 1");
                                        }
                                        if (_mIndexGradient2 >= 0)
                                        {
                                            _mScene._mEffects[_mIndexGradient2]._mState = GUILayout.Toggle(_mScene._mEffects[_mIndexGradient2]._mState, "Gradient 2");
                                        }
                                        if (_mIndexGradient3 >= 0)
                                        {
                                            _mScene._mEffects[_mIndexGradient3]._mState = GUILayout.Toggle(_mScene._mEffects[_mIndexGradient3]._mState, "Gradient 3");
                                        }
                                        if (_mIndexGradient4 >= 0)
                                        {
                                            _mScene._mEffects[_mIndexGradient4]._mState = GUILayout.Toggle(_mScene._mEffects[_mIndexGradient4]._mState, "Gradient 4");
                                        }

                                        GUILayout.FlexibleSpace();
                                    }
                                    GUILayout.EndVertical();

                                    GUILayout.FlexibleSpace();
                                }
                                GUILayout.EndHorizontal();

                            }

                            GUILayout.FlexibleSpace();
                            GUILayout.EndVertical();

                            GUILayout.FlexibleSpace();

                        }

                        GUILayout.EndHorizontal();
                    }
                    break;
                default:
                    GUILayout.BeginVertical(GUILayout.Height(Screen.height));
                    GUILayout.FlexibleSpace();
                    GUILayout.Label(string.Format("Failed to initialize Chroma! {0}", RazerErrors.GetResultString(_mResult)));
                    GUILayout.FlexibleSpace();
                    GUILayout.EndVertical();
                    break;
            }

            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.FlexibleSpace();

            // text mouse
            GUI.Label(new Rect(CustomInput.mousePosition.x, Screen.height - CustomInput.mousePosition.y, 20, 20), "o");
        }
    }

    public void GameLoop()
    {
        int sizeChromaLink = GetColorArraySize1D(Device1D.ChromaLink);
        int sizeHeadset = GetColorArraySize1D(Device1D.Headset);
        int sizeKeyboard = GetColorArraySize2D(Device2D.Keyboard);
        int sizeKeyboardExtended = GetColorArraySize2D(Device2D.KeyboardExtended);
        int sizeKeypad = GetColorArraySize2D(Device2D.Keypad);
        int sizeMouse = GetColorArraySize2D(Device2D.Mouse);
        int sizeMousepad = GetColorArraySize1D(Device1D.Mousepad);

        int[] colorsChromaLink = new int[sizeChromaLink];
        int[] colorsHeadset = new int[sizeHeadset];
        int[] colorsKeyboard = new int[sizeKeyboard];
        int[] colorsKeyboardExtended = new int[sizeKeyboardExtended];
        int[] colorsKeyboardKeys = new int[sizeKeyboard];
        int[] colorsKeypad = new int[sizeKeypad];
        int[] colorsMouse = new int[sizeMouse];
        int[] colorsMousepad = new int[sizeMousepad];

        int[] tempColorsChromaLink = new int[sizeChromaLink];
        int[] tempColorsHeadset = new int[sizeHeadset];
        int[] tempColorsKeyboard = new int[sizeKeyboard];
        int[] tempColorsKeyboardExtended = new int[sizeKeyboardExtended];
        int[] tempColorsKeypad = new int[sizeKeypad];
        int[] tempColorsMouse = new int[sizeMouse];
        int[] tempColorsMousepad = new int[sizeMousepad];

        while (_mWaitForExit)
        {
            // start with a blank frame
            SetStaticColor(colorsChromaLink, _mAmbientColor);
            SetStaticColor(colorsHeadset, _mAmbientColor);
            if (_mExtended)
            {
                SetStaticColor(colorsKeyboardExtended, _mAmbientColor);
            }
            else
            {
                SetStaticColor(colorsKeyboard, _mAmbientColor);
            }
            SetStaticColor(colorsKeyboardKeys, _mAmbientColor);
            SetStaticColor(colorsKeypad, _mAmbientColor);
            SetStaticColor(colorsMouse, _mAmbientColor);
            SetStaticColor(colorsMousepad, _mAmbientColor);

#if !USE_ARRAY_EFFECTS

            SetupAnimation1D(ANIMATION_FINAL_CHROMA_LINK, Device1D.ChromaLink);
            SetupAnimation1D(ANIMATION_FINAL_HEADSET, Device1D.Headset);
            if (_mExtended)
            {
                SetupAnimation2D(ANIMATION_FINAL_KEYBOARD_EXTENDED, Device2D.KeyboardExtended);
                ChromaAnimationAPI.SetChromaCustomFlagName(ANIMATION_FINAL_KEYBOARD_EXTENDED, true);
            }
            else
            {
                SetupAnimation2D(ANIMATION_FINAL_KEYBOARD, Device2D.Keyboard);
                ChromaAnimationAPI.SetChromaCustomFlagName(ANIMATION_FINAL_KEYBOARD, true);
            }
            
            SetupAnimation2D(ANIMATION_FINAL_KEYPAD, Device2D.Keypad);
            SetupAnimation2D(ANIMATION_FINAL_MOUSE, Device2D.Mouse);
            SetupAnimation1D(ANIMATION_FINAL_MOUSEPAD, Device1D.Mousepad);

#endif

            BlendAnimations(_mScene,
                colorsChromaLink, tempColorsChromaLink,
                colorsHeadset, tempColorsHeadset,
                colorsKeyboard, tempColorsKeyboard,
                colorsKeyboardExtended, tempColorsKeyboardExtended,
                colorsKeypad, tempColorsKeypad,
                colorsMouse, tempColorsMouse,
                colorsMousepad, tempColorsMousepad);

            if (_mAmmo)
            {
                // Show health animation
                {
                    int[] keys = {
                            (int)Keyboard.RZKEY.RZKEY_F1,
                            (int)Keyboard.RZKEY.RZKEY_F2,
                            (int)Keyboard.RZKEY.RZKEY_F3,
                            (int)Keyboard.RZKEY.RZKEY_F4,
                            (int)Keyboard.RZKEY.RZKEY_F5,
                            (int)Keyboard.RZKEY.RZKEY_F6,
                        };
                    int keysLength = keys.Length;

                    float t = _mTimeMS * 0.002f;
                    float hp = (float)Math.Abs(Math.Cos(Math.PI / 2.0f + t));
                    for (int i = 0; i < keysLength; ++i)
                    {
                        int color;
                        if (((i + 1) / ((float)keysLength + 1)) < hp)
                        {
                            color = ChromaAnimationAPI.GetRGB(0, 255, 0);
                        }
                        else
                        {
                            color = ChromaAnimationAPI.GetRGB(0, 100, 0);
                        }
                        int key = keys[i];
                        SetKeyColor(colorsKeyboardKeys, key, color);
                    }
                }

                // Show ammo animation
                {
                    int[] keys = {
                            (int)Keyboard.RZKEY.RZKEY_F7,
                            (int)Keyboard.RZKEY.RZKEY_F8,
                            (int)Keyboard.RZKEY.RZKEY_F9,
                            (int)Keyboard.RZKEY.RZKEY_F10,
                            (int)Keyboard.RZKEY.RZKEY_F11,
                            (int)Keyboard.RZKEY.RZKEY_F12,
                        };
                    int keysLength = keys.Length;

                    float t = _mTimeMS * 0.001f;
                    float hp = (float)Math.Abs(Math.Cos(Math.PI / 2.0f + t));
                    for (int i = 0; i < keysLength; ++i)
                    {
                        int color;
                        if (((i + 1) / ((float)keysLength + 1)) < hp)
                        {
                            color = ChromaAnimationAPI.GetRGB(255, 255, 0);
                        }
                        else
                        {
                            color = ChromaAnimationAPI.GetRGB(100, 100, 0);
                        }
                        int key = keys[i];
                        SetKeyColor(colorsKeyboardKeys, key, color);
                    }
                }
            }

            if (_mHotkeys)
            {
                // Highlight if active
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_H, 0, 255, 0);

                // Show hotkeys
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_ESC, 255, 255, 0);
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_A, 255, 0, 0);
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_C, 255, 255, 0);
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_E, 255, 0, 0);
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_P, 255, 255, 0);
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_1, 255, 0, 0);
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_2, 255, 0, 0);
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_3, 255, 0, 0);
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_4, 255, 0, 0);

                if (_mAmmo)
                {
                    SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_A, 0, 255, 0);
                }

                if (_mExtended)
                {
                    SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_E, 0, 255, 0);
                }

                // Highlight if active
                if (_mScene._mEffects[_mIndexGradient1]._mState)
                {
                    SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_1, 0, 255, 0);
                }

                // Highlight if active
                if (_mScene._mEffects[_mIndexGradient2]._mState)
                {
                    SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_2, 0, 255, 0);
                }

                // Highlight if active
                if (_mScene._mEffects[_mIndexGradient3]._mState)
                {
                    SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_3, 0, 255, 0);
                }

                // Highlight if active
                if (_mScene._mEffects[_mIndexGradient4]._mState)
                {
                    SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_4, 0, 255, 0);
                }
            }
            else
            {
                SetKeyColorRGB(colorsKeyboardKeys, (int)Keyboard.RZKEY.RZKEY_H, 255, 0, 0);
            }

#if USE_ARRAY_EFFECTS

            ChromaAnimationAPI.SetEffectCustom1D((int)Device1D.ChromaLink, colorsChromaLink);
            ChromaAnimationAPI.SetEffectCustom1D((int)Device1D.Headset, colorsHeadset);
            ChromaAnimationAPI.SetEffectCustom1D((int)Device1D.Mousepad, colorsMousepad);

            if (_mExtended)
            {
                ChromaAnimationAPI.SetCustomColorFlag2D((int)Device2D.KeyboardExtended, colorsKeyboardExtended);
                ChromaAnimationAPI.SetEffectKeyboardCustom2D((int)Device2D.KeyboardExtended, colorsKeyboardExtended, colorsKeyboardKeys);
            }
            else
            {
                ChromaAnimationAPI.SetCustomColorFlag2D((int)Device2D.Keyboard, colorsKeyboard);
                ChromaAnimationAPI.SetEffectKeyboardCustom2D((int)Device2D.Keyboard, colorsKeyboard, colorsKeyboardKeys);
            }

            ChromaAnimationAPI.SetEffectCustom2D((int)Device2D.Keypad, colorsKeypad);
            ChromaAnimationAPI.SetEffectCustom2D((int)Device2D.Mouse, colorsMouse);

#else

            ChromaAnimationAPI.UpdateFrameName(ANIMATION_FINAL_CHROMA_LINK, 0, 0.033f, colorsChromaLink, sizeChromaLink, null, 0);
            ChromaAnimationAPI.UpdateFrameName(ANIMATION_FINAL_HEADSET, 0, 0.033f, colorsHeadset, sizeHeadset, null, 0);
            if (_mExtended)
            {
                ChromaAnimationAPI.UpdateFrameName(ANIMATION_FINAL_KEYBOARD_EXTENDED, 0, 0.033f, colorsKeyboardExtended, sizeKeyboardExtended, colorsKeyboardKeys, sizeKeyboard);
            }
            else
            {
                ChromaAnimationAPI.UpdateFrameName(ANIMATION_FINAL_KEYBOARD, 0, 0.033f, colorsKeyboard, sizeKeyboard, colorsKeyboardKeys, sizeKeyboard);
            }
            ChromaAnimationAPI.UpdateFrameName(ANIMATION_FINAL_KEYPAD, 0, 0.033f, colorsKeypad, sizeKeypad, null, 0);
            ChromaAnimationAPI.UpdateFrameName(ANIMATION_FINAL_MOUSE, 0, 0.033f, colorsMouse, sizeMouse, null, 0);
            ChromaAnimationAPI.UpdateFrameName(ANIMATION_FINAL_MOUSEPAD, 0, 0.033f, colorsMousepad, sizeMousepad, null, 0);

            // display the change
            ChromaAnimationAPI.PreviewFrameName(ANIMATION_FINAL_CHROMA_LINK, 0);
            ChromaAnimationAPI.PreviewFrameName(ANIMATION_FINAL_HEADSET, 0);
            if (_mExtended)
            {
                ChromaAnimationAPI.PreviewFrameName(ANIMATION_FINAL_KEYBOARD_EXTENDED, 0);
            }
            else
            {
                ChromaAnimationAPI.PreviewFrameName(ANIMATION_FINAL_KEYBOARD, 0);
            }
            ChromaAnimationAPI.PreviewFrameName(ANIMATION_FINAL_KEYPAD, 0);
            ChromaAnimationAPI.PreviewFrameName(ANIMATION_FINAL_MOUSE, 0);
            ChromaAnimationAPI.PreviewFrameName(ANIMATION_FINAL_MOUSEPAD, 0);

#endif

            Thread.Sleep(33); //30 FPS
        }

    }

    private void Update()
    {
        // get time
        _mTimeMS = (int)(Time.time * 1000) & 0xFFFF;
    }
}
