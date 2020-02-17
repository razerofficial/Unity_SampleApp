using ChromaSDK;
using UnityEngine;

public class SampleApp : MonoBehaviour
{
    bool _mInitialized = false;
    int _mResult = 0;

    const int MAX_SAMPLE_COUNT = 46;

    public void Start()
    {
        _mResult = ChromaAnimationAPI.Init();
        _mInitialized = true;
        switch (_mResult)
        {
            case RazerErrors.RZRESULT_DLL_NOT_FOUND:
                Debug.LogError(string.Format("Chroma DLL is not found! {0}", RazerErrors.GetResultString(_mResult)));
                break;
            case RazerErrors.RZRESULT_DLL_INVALID_SIGNATURE:
                Debug.LogError(string.Format("Chroma DLL has an invalid signature! {0}", RazerErrors.GetResultString(_mResult)));
                break;
            case RazerErrors.RZRESULT_SUCCESS:
                break;
            default:
                Debug.LogError(string.Format("Failed to initialize Chroma! {0}", RazerErrors.GetResultString(_mResult)));
                break;
        }
    }
    public void OnApplicationQuit()
    {
        ChromaAnimationAPI.Uninit();
    }

    private string GetEffectName(int index)
    {
        string result = string.Format("Effect{0}", index);
        return result;
    }

    private bool ShowHeader(int index)
    {
        switch (index)
        {
            case 1:
            case 10:
            case 20:
            case 30:
            case 40:
                return true;
            default:
                return false;
        }
    }

    private bool ShowFooter(int index)
    {
        switch (index)
        {
            case 9:
            case 19:
            case 29:
            case 39:
                return true;
            default:
                return false;
        }
    }

    private void ExecuteItem(int index)
    {
        switch (index)
        {
            case 1:
                ShowEffect1();
                ShowEffect1ChromaLink();
                ShowEffect1Headset();
                ShowEffect1Keypad();
                ShowEffect1Mousepad();
                ShowEffect1Mouse();
                break;
            case 2:
                ShowEffect2();
                ShowEffect2ChromaLink();
                ShowEffect2Headset();
                ShowEffect2Keypad();
                ShowEffect2Mousepad();
                ShowEffect2Mouse();
                break;
            case 3:
                ShowEffect3();
                ShowEffect3ChromaLink();
                ShowEffect3Headset();
                ShowEffect3Keypad();
                ShowEffect3Mousepad();
                ShowEffect3Mouse();
                break;
            case 4:
                ShowEffect4();
                ShowEffect4ChromaLink();
                ShowEffect4Headset();
                ShowEffect4Keypad();
                ShowEffect4Mousepad();
                ShowEffect4Mouse();
                break;
            case 5:
                ShowEffect5();
                ShowEffect5ChromaLink();
                ShowEffect5Headset();
                ShowEffect5Keypad();
                ShowEffect5Mousepad();
                ShowEffect5Mouse();
                break;
            case 6:
                ShowEffect6();
                ShowEffect6ChromaLink();
                ShowEffect6Headset();
                ShowEffect6Keypad();
                ShowEffect6Mousepad();
                ShowEffect6Mouse();
                break;
            case 7:
                ShowEffect7();
                ShowEffect7ChromaLink();
                ShowEffect7Headset();
                ShowEffect7Keypad();
                ShowEffect7Mousepad();
                ShowEffect7Mouse();
                break;
            case 8:
                ShowEffect8();
                ShowEffect8ChromaLink();
                ShowEffect8Headset();
                ShowEffect8Keypad();
                ShowEffect8Mousepad();
                ShowEffect8Mouse();
                break;
            case 9:
                ShowEffect9();
                ShowEffect9ChromaLink();
                ShowEffect9Headset();
                ShowEffect9Keypad();
                ShowEffect9Mousepad();
                ShowEffect9Mouse();
                break;
            case 10:
                ShowEffect10();
                ShowEffect10ChromaLink();
                ShowEffect10Headset();
                ShowEffect10Keypad();
                ShowEffect10Mousepad();
                ShowEffect10Mouse();
                break;
            case 11:
                ShowEffect11();
                ShowEffect11ChromaLink();
                ShowEffect11Headset();
                ShowEffect11Keypad();
                ShowEffect11Mousepad();
                ShowEffect11Mouse();
                break;
            case 12:
                ShowEffect12();
                ShowEffect12ChromaLink();
                ShowEffect12Headset();
                ShowEffect12Keypad();
                ShowEffect12Mousepad();
                ShowEffect12Mouse();
                break;
            case 13:
                ShowEffect13();
                ShowEffect13ChromaLink();
                ShowEffect13Headset();
                ShowEffect13Keypad();
                ShowEffect13Mousepad();
                ShowEffect13Mouse();
                break;
            case 14:
                ShowEffect14();
                ShowEffect14ChromaLink();
                ShowEffect14Headset();
                ShowEffect14Keypad();
                ShowEffect14Mousepad();
                ShowEffect14Mouse();
                break;
            case 15:
                ShowEffect15();
                ShowEffect15ChromaLink();
                ShowEffect15Headset();
                ShowEffect15Keypad();
                ShowEffect15Mousepad();
                ShowEffect15Mouse();
                break;
            case 16:
                ShowEffect16();
                ShowEffect16ChromaLink();
                ShowEffect16Headset();
                ShowEffect16Keypad();
                ShowEffect16Mousepad();
                ShowEffect16Mouse();
                break;
            case 17:
                ShowEffect17();
                ShowEffect17ChromaLink();
                ShowEffect17Headset();
                ShowEffect17Keypad();
                ShowEffect17Mousepad();
                ShowEffect17Mouse();
                break;
            case 18:
                ShowEffect18();
                ShowEffect18ChromaLink();
                ShowEffect18Headset();
                ShowEffect18Keypad();
                ShowEffect18Mousepad();
                ShowEffect18Mouse();
                break;
            case 19:
                ShowEffect19();
                ShowEffect19ChromaLink();
                ShowEffect19Headset();
                ShowEffect19Keypad();
                ShowEffect19Mousepad();
                ShowEffect19Mouse();
                break;
            case 20:
                ShowEffect20();
                ShowEffect20ChromaLink();
                ShowEffect20Headset();
                ShowEffect20Keypad();
                ShowEffect20Mousepad();
                ShowEffect20Mouse();
                break;
            case 21:
                ShowEffect21();
                ShowEffect21ChromaLink();
                ShowEffect21Headset();
                ShowEffect21Keypad();
                ShowEffect21Mousepad();
                ShowEffect21Mouse();
                break;
            case 22:
                ShowEffect22();
                ShowEffect22ChromaLink();
                ShowEffect22Headset();
                ShowEffect22Keypad();
                ShowEffect22Mousepad();
                ShowEffect22Mouse();
                break;
            case 23:
                ShowEffect23();
                ShowEffect23ChromaLink();
                ShowEffect23Headset();
                ShowEffect23Keypad();
                ShowEffect23Mousepad();
                ShowEffect23Mouse();
                break;
            case 24:
                ShowEffect24();
                ShowEffect24ChromaLink();
                ShowEffect24Headset();
                ShowEffect24Keypad();
                ShowEffect24Mousepad();
                ShowEffect24Mouse();
                break;
            case 25:
                ShowEffect25();
                ShowEffect25ChromaLink();
                ShowEffect25Headset();
                ShowEffect25Keypad();
                ShowEffect25Mousepad();
                ShowEffect25Mouse();
                break;
            case 26:
                ShowEffect26();
                ShowEffect26ChromaLink();
                ShowEffect26Headset();
                ShowEffect26Keypad();
                ShowEffect26Mousepad();
                ShowEffect26Mouse();
                break;
            case 27:
                ShowEffect27();
                ShowEffect27ChromaLink();
                ShowEffect27Headset();
                ShowEffect27Keypad();
                ShowEffect27Mousepad();
                ShowEffect27Mouse();
                break;
            case 28:
                ShowEffect28();
                ShowEffect28ChromaLink();
                ShowEffect28Headset();
                ShowEffect28Keypad();
                ShowEffect28Mousepad();
                ShowEffect28Mouse();
                break;
            case 29:
                ShowEffect29();
                ShowEffect29ChromaLink();
                ShowEffect29Headset();
                ShowEffect29Keypad();
                ShowEffect29Mousepad();
                ShowEffect29Mouse();
                break;
            case 30:
                ShowEffect30();
                ShowEffect30ChromaLink();
                ShowEffect30Headset();
                ShowEffect30Keypad();
                ShowEffect30Mousepad();
                ShowEffect30Mouse();
                break;
            case 31:
                ShowEffect31();
                ShowEffect31ChromaLink();
                ShowEffect31Headset();
                ShowEffect31Keypad();
                ShowEffect31Mousepad();
                ShowEffect31Mouse();
                break;
            case 32:
                ShowEffect32();
                ShowEffect32ChromaLink();
                ShowEffect32Headset();
                ShowEffect32Keypad();
                ShowEffect32Mousepad();
                ShowEffect32Mouse();
                break;
            case 33:
                ShowEffect33();
                ShowEffect33ChromaLink();
                ShowEffect33Headset();
                ShowEffect33Keypad();
                ShowEffect33Mousepad();
                ShowEffect33Mouse();
                break;
            case 34:
                ShowEffect34();
                ShowEffect34ChromaLink();
                ShowEffect34Headset();
                ShowEffect34Keypad();
                ShowEffect34Mousepad();
                ShowEffect34Mouse();
                break;
            case 35:
                ShowEffect35();
                ShowEffect35ChromaLink();
                ShowEffect35Headset();
                ShowEffect35Keypad();
                ShowEffect35Mousepad();
                ShowEffect35Mouse();
                break;
            case 36:
                ShowEffect36();
                ShowEffect36ChromaLink();
                ShowEffect36Headset();
                ShowEffect36Keypad();
                ShowEffect36Mousepad();
                ShowEffect36Mouse();
                break;
            case 37:
                ShowEffect37();
                ShowEffect37ChromaLink();
                ShowEffect37Headset();
                ShowEffect37Keypad();
                ShowEffect37Mousepad();
                ShowEffect37Mouse();
                break;
            case 38:
                ShowEffect38();
                ShowEffect38ChromaLink();
                ShowEffect38Headset();
                ShowEffect38Keypad();
                ShowEffect38Mousepad();
                ShowEffect38Mouse();
                break;
            case 39:
                ShowEffect39();
                ShowEffect39ChromaLink();
                ShowEffect39Headset();
                ShowEffect39Keypad();
                ShowEffect39Mousepad();
                ShowEffect39Mouse();
                break;
            case 40:
                ShowEffect40();
                ShowEffect40ChromaLink();
                ShowEffect40Headset();
                ShowEffect40Keypad();
                ShowEffect40Mousepad();
                ShowEffect40Mouse();
                break;
            case 41:
                ShowEffect41();
                ShowEffect41ChromaLink();
                ShowEffect41Headset();
                ShowEffect41Keypad();
                ShowEffect41Mousepad();
                ShowEffect41Mouse();
                break;
            case 42:
                ShowEffect42();
                ShowEffect42ChromaLink();
                ShowEffect42Headset();
                ShowEffect42Keypad();
                ShowEffect42Mousepad();
                ShowEffect42Mouse();
                break;
            case 43:
                ShowEffect43();
                ShowEffect43ChromaLink();
                ShowEffect43Headset();
                ShowEffect43Keypad();
                ShowEffect43Mousepad();
                ShowEffect43Mouse();
                break;
            case 44:
                ShowEffect44();
                ShowEffect44ChromaLink();
                ShowEffect44Headset();
                ShowEffect44Keypad();
                ShowEffect44Mousepad();
                ShowEffect44Mouse();
                break;
            case 45:
                ShowEffect45();
                ShowEffect45ChromaLink();
                ShowEffect45Headset();
                ShowEffect45Keypad();
                ShowEffect45Mousepad();
                ShowEffect45Mouse();
                break;
            case 46:
                ShowEffect46();
                ShowEffect46ChromaLink();
                ShowEffect46Headset();
                ShowEffect46Keypad();
                ShowEffect46Mousepad();
                ShowEffect46Mouse();
                break;
        }
    }

    private bool _mLastMouseLeftDown = false;
    private string _mLastButtonName = string.Empty;
    private int _mGamepadIndex = -1;

    private void Update()
    {
        // joy dpad up
        if (Input.GetKeyUp(KeyCode.Joystick1Button12))
        {
            if (_mGamepadIndex > 0)
            {
                --_mGamepadIndex;
                _mLastButtonName = GetEffectName(_mGamepadIndex);
            }
        }
        // joy dpad down
        else if (Input.GetKeyUp(KeyCode.Joystick1Button13))
        {
            if (_mGamepadIndex < MAX_SAMPLE_COUNT)
            {
                ++_mGamepadIndex;
                _mLastButtonName = GetEffectName(_mGamepadIndex);
            }
        }
        // joy button a
        else if (Input.GetKeyUp(KeyCode.Joystick1Button0))
        {
            if (_mGamepadIndex >= 0 && _mGamepadIndex < MAX_SAMPLE_COUNT)
            {
                ExecuteItem(_mGamepadIndex);
            }
        }
    }

    public void OnGUI()
    {
        GUILayout.FlexibleSpace();
        GUILayout.BeginHorizontal(GUILayout.Width(Screen.width));
        GUILayout.FlexibleSpace();

        if (!_mInitialized)
        {
            GUILayout.BeginVertical(GUILayout.Height(Screen.height));
            GUILayout.FlexibleSpace();
            GUILayout.Label("Sample has not yet initialized!");
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
                        const float height = 40;

                        for (int index = 1; index <= MAX_SAMPLE_COUNT; ++index)
                        {
                            if (ShowHeader(index))
                            {
                                GUILayout.BeginVertical(GUILayout.Height(Screen.height));
                                GUILayout.FlexibleSpace();
                            }

                            if (index == 1)
                            {
                                GUILayout.BeginHorizontal(GUILayout.Width(200));
                                GUILayout.Label(string.Format("Mouse X: {0} Y: {1}", 
                                    Input.mousePosition.x, Input.mousePosition.y));
                                GUILayout.EndHorizontal();
                                GUILayout.Label(string.Format("LEFT: {0}", Input.GetMouseButton(0) ? "DOWN" : "UP"));
                                GUILayout.Label(string.Format("MIDDLE: {0}", Input.GetMouseButton(2) ? "DOWN" : "UP"));
                                GUILayout.Label(string.Format("RIGHT: {0}", Input.GetMouseButton(1) ? "DOWN" : "UP"));

                                GUILayout.Label(string.Format("JOY DPAD UP: {0}",
                                    Input.GetKey(KeyCode.Joystick1Button12) ? "DOWN" : "UP"));

                                GUILayout.Label(string.Format("JOY DPAD DOWN: {0}",
                                    Input.GetKey(KeyCode.Joystick1Button13) ? "DOWN" : "UP"));

                                GUILayout.Label(string.Format("JOY BUTTON A: {0}",
                                    Input.GetKey(KeyCode.Joystick1Button0) ? "DOWN" : "UP"));
                            }

                            string buttonName = GetEffectName(index);
                            Color oldColor = GUI.backgroundColor;
                            if (buttonName == _mLastButtonName)
                            {
                                GUI.backgroundColor = Color.green;
                            }
                            GUILayout.Button(buttonName, GUILayout.Height(height));
                            if (buttonName == _mLastButtonName)
                            {
                                GUI.backgroundColor = oldColor;
                            }
                            Rect rect = GUILayoutUtility.GetLastRect();
                            Vector3 pos = Input.mousePosition;
                            pos.y = Screen.height - Input.mousePosition.y;
                            if (rect.Contains(pos))
                            {
                                if (Input.GetMouseButton(0))
                                {
                                    _mLastMouseLeftDown = true;
                                }
                                else if (_mLastMouseLeftDown)
                                {
                                    _mLastMouseLeftDown = false;
                                    _mLastButtonName = buttonName;
                                    ExecuteItem(index);
                                }
                            }

                            if (ShowFooter(index))
                            {
                                GUILayout.FlexibleSpace();
                                GUILayout.EndVertical();
                            }

                        }
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
            GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 20, 20), "o");
        }
    }

    #region Autogenerated
    void ShowEffect1()
    {
        ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.Keyboard, false);
        // start with a blank animation
        string baseLayer = "animations/Sprite1_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect1ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Sprite1_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect1Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Sprite1_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect1Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Sprite1_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect1Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Sprite1_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect1Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Sprite1_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect2()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect2ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect2Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect2Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect2Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect2Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect3()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set middle color green
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 0);
        int minThreshold = 50; //set outer color to red
        int maxThreshold = 150; //set main color to blue
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 255, 0, 0, maxThreshold, 0, 0, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect3ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set middle color green
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 0);
        int minThreshold = 50; //set outer color to red
        int maxThreshold = 150; //set main color to blue
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 255, 0, 0, maxThreshold, 0, 0, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect3Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set middle color green
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 0);
        int minThreshold = 50; //set outer color to red
        int maxThreshold = 150; //set main color to blue
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 255, 0, 0, maxThreshold, 0, 0, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect3Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set middle color green
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 0);
        int minThreshold = 50; //set outer color to red
        int maxThreshold = 150; //set main color to blue
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 255, 0, 0, maxThreshold, 0, 0, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect3Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set middle color green
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 0);
        int minThreshold = 50; //set outer color to red
        int maxThreshold = 150; //set main color to blue
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 255, 0, 0, maxThreshold, 0, 0, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect3Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // static color
        ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 255, 0, 0);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect4()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect4ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect4Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect4Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect4Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect4Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect5()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // turn grayscale particles to blue water
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect5ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // turn grayscale particles to blue water
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect5Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // turn grayscale particles to blue water
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect5Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // turn grayscale particles to blue water
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect5Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // turn grayscale particles to blue water
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect5Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/ParticlesOut_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // turn grayscale particles to blue water
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect6()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect6ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect6Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect6Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect6Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect6Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect7()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect7ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect7Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect7Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect7Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect7Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect8()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect8ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect8Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect8Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect8Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect8Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        // fade the start of the animation starting at frame zero to 40
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
        // fade the end of the animation starting at frame length - 40 (60)
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect9()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        //integer number of times to blink during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
            float t = 1 - Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // multiply the frame by the 't' intensity
            ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect9ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        //integer number of times to blink during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
            float t = 1 - Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // multiply the frame by the 't' intensity
            ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect9Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        //integer number of times to blink during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
            float t = 1 - Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // multiply the frame by the 't' intensity
            ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect9Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        //integer number of times to blink during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
            float t = 1 - Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // multiply the frame by the 't' intensity
            ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect9Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        //integer number of times to blink during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
            float t = 1 - Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // multiply the frame by the 't' intensity
            ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect9Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
        //integer number of times to blink during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
            float t = 1 - Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // multiply the frame by the 't' intensity
            ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect10()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect10ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect10Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect10Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect10Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect10Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect11()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce the intensity of the layer
        ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect11ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce the intensity of the layer
        ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect11Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce the intensity of the layer
        ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect11Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce the intensity of the layer
        ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect11Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce the intensity of the layer
        ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect11Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Particles2_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce the intensity of the layer
        ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect12()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect12ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect12Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect12Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect12Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect12Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect13()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect13ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect13Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect13Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect13Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect13Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect14()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                      // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect14ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                      // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect14Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                      // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect14Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                      // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect14Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                      // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect14Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                      // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect15()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                           //integer number of times to transition during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve
            float t = Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // use t to transition from color 1 to color 2
            int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect15ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                           //integer number of times to transition during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve
            float t = Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // use t to transition from color 1 to color 2
            int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect15Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                           //integer number of times to transition during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve
            float t = Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // use t to transition from color 1 to color 2
            int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect15Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                           //integer number of times to transition during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve
            float t = Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // use t to transition from color 1 to color 2
            int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect15Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                           //integer number of times to transition during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve
            float t = Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // use t to transition from color 1 to color 2
            int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect15Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                           //integer number of times to transition during animation
        float speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve
            float t = Mathf.Abs(Mathf.Cos(speed * Mathf.PI * (frameId + 1) / (float)frameCount));
            // use t to transition from color 1 to color 2
            int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect16()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect16ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect16Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect16Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect16Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect16Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect17()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            int threshold = 100;
            // give color to the layer
            ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect17ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            int threshold = 100;
            // give color to the layer
            ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect17Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            int threshold = 100;
            // give color to the layer
            ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect17Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            int threshold = 100;
            // give color to the layer
            ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect17Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            int threshold = 100;
            // give color to the layer
            ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect17Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            int threshold = 100;
            // give color to the layer
            ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect18()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int threshold = 50;
        ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect18ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int threshold = 50;
        ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect18Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int threshold = 50;
        ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect18Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int threshold = 50;
        ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect18Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int threshold = 50;
        ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect18Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int threshold = 50;
        ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect19()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int minThreshold = 50; //dark cyan
        int maxThreshold = 150; //purple
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect19ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int minThreshold = 50; //dark cyan
        int maxThreshold = 150; //purple
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect19Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int minThreshold = 50; //dark cyan
        int maxThreshold = 150; //purple
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect19Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int minThreshold = 50; //dark cyan
        int maxThreshold = 150; //purple
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect19Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int minThreshold = 50; //dark cyan
        int maxThreshold = 150; //purple
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect19Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Trails_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int minThreshold = 50; //dark cyan
        int maxThreshold = 150; //purple
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect20()
    {
        // start with a blank animation
        string baseLayer = "animations/Arc3_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect20ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Arc3_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect20Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Arc3_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect20Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Arc3_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect20Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Arc3_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect20Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Arc3_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect21()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        string layer2 = "animations/Arc3_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect21ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        string layer2 = "animations/Arc3_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect21Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        string layer2 = "animations/Arc3_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect21Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        string layer2 = "animations/Arc3_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect21Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        string layer2 = "animations/Arc3_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect21Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        string layer2 = "animations/Arc3_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect22()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        string layer2 = "animations/Arc3_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // replace darker colors with background color
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect22ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        string layer2 = "animations/Arc3_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // replace darker colors with background color
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect22Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        string layer2 = "animations/Arc3_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // replace darker colors with background color
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect22Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        string layer2 = "animations/Arc3_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // replace darker colors with background color
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect22Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        string layer2 = "animations/Arc3_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // replace darker colors with background color
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect22Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        string layer2 = "animations/Arc3_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // replace darker colors with background color
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
        // copy non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect23()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        string layer2 = "animations/Arc3_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect23ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        string layer2 = "animations/Arc3_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect23Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        string layer2 = "animations/Arc3_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect23Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        string layer2 = "animations/Arc3_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect23Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        string layer2 = "animations/Arc3_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect23Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        string layer2 = "animations/Arc3_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect24()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        string layer2 = "animations/Arc3_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect24ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        string layer2 = "animations/Arc3_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect24Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        string layer2 = "animations/Arc3_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect24Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        string layer2 = "animations/Arc3_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect24Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        string layer2 = "animations/Arc3_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect24Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        string layer2 = "animations/Arc3_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        // setup background color on the base layer
        int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
        // Add non zero colors from layer 2 to the base layer
        ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect25()
    {
        // start with a blank animation
        string baseLayer = "Animations/CircleSmall_Keyboard.chroma";
        string layer2 = "animations/Rainbow_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
        ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
        // copy non zero colors from layer 2 to the base layer where the base layer was non zero
        ChromaAnimationAPI.CopyNonZeroTargetAllKeysAllFramesName(layer2, baseLayer);
        // set a background color
        ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 255, 0, 0);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect25ChromaLink()
    {
        string baseLayer = "animations/Rainbow_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect25Headset()
    {
        string baseLayer = "animations/Rainbow_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect25Mousepad()
    {
        string baseLayer = "animations/Rainbow_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect25Mouse()
    {
        string baseLayer = "animations/Rainbow_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect25Keypad()
    {
        string baseLayer = "animations/Rainbow_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect26()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect26ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect26Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect26Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect26Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect26Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect27()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect27ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect27Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect27Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect27Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect27Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect28()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reverse the order of frames
        ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect28ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reverse the order of frames
        ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect28Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reverse the order of frames
        ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect28Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reverse the order of frames
        ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect28Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reverse the order of frames
        ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect28Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reverse the order of frames
        ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect29()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // invert all the animation colors
        ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect29ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // invert all the animation colors
        ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect29Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // invert all the animation colors
        ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect29Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // invert all the animation colors
        ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect29Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // invert all the animation colors
        ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect29Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // invert all the animation colors
        ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect30()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // duplicate and mirror
        ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect30ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // duplicate and mirror
        ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect30Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // duplicate and mirror
        ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect30Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // duplicate and mirror
        ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect30Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // duplicate and mirror
        ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect30Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // duplicate and mirror
        ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect31()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // insert a pause
        int frameId = 50;
        int delay = 20;
        ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect31ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // insert a pause
        int frameId = 50;
        int delay = 20;
        ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect31Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // insert a pause
        int frameId = 50;
        int delay = 20;
        ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect31Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // insert a pause
        int frameId = 50;
        int delay = 20;
        ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect31Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // insert a pause
        int frameId = 50;
        int delay = 20;
        ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect31Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // insert a pause
        int frameId = 50;
        int delay = 20;
        ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect32()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce half of the frames, remove every 2nd frame
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect32ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce half of the frames, remove every 2nd frame
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect32Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce half of the frames, remove every 2nd frame
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect32Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce half of the frames, remove every 2nd frame
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect32Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce half of the frames, remove every 2nd frame
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect32Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce half of the frames, remove every 2nd frame
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect33()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // double the number of the frames
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect33ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // double the number of the frames
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect33Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // double the number of the frames
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect33Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // double the number of the frames
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect33Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // double the number of the frames
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect33Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // double the number of the frames
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect34()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect34ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect34Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect34Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect34Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect34Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect35()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // trim the end of the animation
        ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect35ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // trim the end of the animation
        ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect35Headset()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // trim the end of the animation
        ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect35Mousepad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // trim the end of the animation
        ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect35Mouse()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // trim the end of the animation
        ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect35Keypad()
    {
        // start with a blank animation
        string baseLayer = "animations/Movement_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // trim the start of the animation, so it starts at frame 10
        ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
        // trim the end of the animation
        ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect36()
    {
        // start with a blank animation
        string baseLayer = "Animations/CircleSmall_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect36ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // green
        ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 0, 255, 0);
        int frameCount = 20;
        ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect36Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // green
        ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 0, 255, 0);
        int frameCount = 20;
        ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect36Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // green
        ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 0, 255, 0);
        int frameCount = 20;
        ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect36Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // green
        ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 0, 255, 0);
        int frameCount = 20;
        ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect36Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // green
        ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 0, 255, 0);
        int frameCount = 20;
        ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect37()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect37ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect37Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect37Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect37Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect37Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect38()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // make random colors more sparse using threshold
        int threshold = 240;
        // turn lower intensity colors to black
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect38ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // make random colors more sparse using threshold
        int threshold = 240;
        // turn lower intensity colors to black
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect38Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // make random colors more sparse using threshold
        int threshold = 240;
        // turn lower intensity colors to black
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect38Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // make random colors more sparse using threshold
        int threshold = 240;
        // turn lower intensity colors to black
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect38Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // make random colors more sparse using threshold
        int threshold = 240;
        // turn lower intensity colors to black
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect38Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        // make random colors more sparse using threshold
        int threshold = 240;
        // turn lower intensity colors to black
        ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect39()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        int minThreshold = 240; //black
        int maxThreshold = 240; //rain
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect39ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        int minThreshold = 240; //black
        int maxThreshold = 240; //rain
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect39Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        int minThreshold = 240; //black
        int maxThreshold = 240; //rain
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect39Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        int minThreshold = 240; //black
        int maxThreshold = 240; //rain
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect39Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        int minThreshold = 240; //black
        int maxThreshold = 240; //rain
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect39Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 20;
        // Start with blank frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
        // Fill all frames with black and white static
        ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
        // slow down the random frames so it can be seen
        ChromaAnimationAPI.DuplicateFramesName(baseLayer);
        int minThreshold = 240; //black
        int maxThreshold = 240; //rain
        ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect40()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        string idleAnimation = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(idleAnimation);
        // Set idle animation
        ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
        // Enable idle animation
        ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.Keyboard, true);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // Transition from green to red and then stop
        int frameCount = 30;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
        ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
    }
    void ShowEffect40ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        string idleAnimation = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(idleAnimation);
        // Set idle animation
        ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
        // Enable idle animation
        ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.ChromaLink, true);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // Transition from green to red and then stop
        int frameCount = 30;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
        ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
    }
    void ShowEffect40Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        string idleAnimation = "Animations/BlackAndWhiteRainbow_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(idleAnimation);
        // Set idle animation
        ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
        // Enable idle animation
        ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.Headset, true);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // Transition from green to red and then stop
        int frameCount = 30;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
        ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
    }
    void ShowEffect40Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        string idleAnimation = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(idleAnimation);
        // Set idle animation
        ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
        // Enable idle animation
        ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.Mousepad, true);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // Transition from green to red and then stop
        int frameCount = 30;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
        ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
    }
    void ShowEffect40Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        string idleAnimation = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(idleAnimation);
        // Set idle animation
        ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
        // Enable idle animation
        ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.Mouse, true);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // Transition from green to red and then stop
        int frameCount = 30;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
        ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
    }
    void ShowEffect40Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        string idleAnimation = "Animations/BlackAndWhiteRainbow_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(idleAnimation);
        // Set idle animation
        ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
        // Enable idle animation
        ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.Mouse, true);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // Transition from green to red and then stop
        int frameCount = 30;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
        ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
    }
    void ShowEffect41()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 0, 64);
        int maxRow = ChromaAnimationAPI.GetMaxRow(ChromaAnimationAPI.Device2D.Keyboard);
        int maxColumn = ChromaAnimationAPI.GetMaxColumn(ChromaAnimationAPI.Device2D.Keyboard);
        int startColumn = (int)Mathf.Floor(Random.Range(0.0f, 1.0f) * maxColumn) % 22;
        int startRow = (int)Mathf.Floor(Random.Range(0.0f, 1.0f) * maxRow) % 6;
        int color = ChromaAnimationAPI.GetRGB(0, 255, 0);
        float radius = 0;
        float speed = 25 / (float)frameCount;
        int lineWidth = 2;
        for (int frameIndex = 0; frameIndex < frameCount; ++frameIndex)
        {
            float stroke = radius;
            for (int t = 0; t < lineWidth; ++t)
            {
                for (int i = 0; i < 360; ++i)
                {
                    float angle = i * Mathf.PI / 180.0f;
                    int r = (int)Mathf.Floor(startRow + stroke * Mathf.Sin(angle));
                    int c = (int)Mathf.Floor(startColumn + stroke * Mathf.Cos(angle));
                    if (r >= 0 && r < maxRow &&
                    c >= 0 && c < maxColumn)
                    {
                        int key = (r << 8) | c;
                        ChromaAnimationAPI.SetKeyColorName(baseLayer, frameIndex, key, color);
                    }
                }
                stroke += speed;
            }
            radius += speed;
        }
        // play at top speed
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect41ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // solid color
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 255, 64);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect41Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // solid color
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 255, 64);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect41Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // solid color
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 255, 64);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect41Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // solid color
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 255, 64);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect41Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // solid color
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 255, 64);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect42()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 1;
        // set all frames to white, with all frames set to 30FPS
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 0, 64);
        int maxRow = ChromaAnimationAPI.GetMaxRow(ChromaAnimationAPI.Device2D.Keyboard);
        int maxColumn = ChromaAnimationAPI.GetMaxColumn(ChromaAnimationAPI.Device2D.Keyboard);
        // pick first key
        int pointAColumn = (int)Mathf.Floor(Random.Range(0.0f, 1.0f) * maxColumn) % 22;
        int pointARow = (int)Mathf.Floor(Random.Range(0.0f, 1.0f) * maxRow) % 6;
        // pick a different second key
        int pointBColumn;
        int pointBRow;
        do
        {
            pointBColumn = (int)Mathf.Floor(Random.Range(0.0f, 1.0f) * maxColumn) % 22;
            pointBRow = (int)Mathf.Floor(Random.Range(0.0f, 1.0f) * maxRow) % 6;
        } while (pointAColumn == pointBColumn && pointARow == pointBRow);
        int color = ChromaAnimationAPI.GetRGB(0, 255, 0);
        int frameIndex = 0;
        for (float i = 0.0f; i <= 1.0f; i += 0.04f)
        { // 1.0/22.0
            int r = (int)Mathf.Floor(ChromaAnimationAPI.Lerp(pointARow, pointBRow, i));
            int c = (int)Mathf.Floor(ChromaAnimationAPI.Lerp(pointAColumn, pointBColumn, i));
            if (r >= 0 && r < maxRow &&
            c >= 0 && c < maxColumn)
            {
                int key = (r << 8) | c;
                ChromaAnimationAPI.SetKeyColorName(baseLayer, frameIndex, key, color);
            }
        }
        // play at top speed
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect42ChromaLink()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // solid color
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 255, 64);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect42Headset()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Headset.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // solid color
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 255, 64);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect42Mousepad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // solid color
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 255, 64);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect42Mouse()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Mouse.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // solid color
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 255, 64);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect42Keypad()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keypad.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // the length of the animation
        int frameCount = 50;
        // solid color
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 64, 255, 64);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect43()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(64, 0, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        int[] keys = {
(int)Keyboard.RZKEY.RZKEY_W,
(int)Keyboard.RZKEY.RZKEY_A,
(int)Keyboard.RZKEY.RZKEY_S,
(int)Keyboard.RZKEY.RZKEY_D,
(int)Keyboard.RZKEY.RZKEY_P,
(int)Keyboard.RZKEY.RZKEY_M,
(int)Keyboard.RZKEY.RZKEY_F1,
};
        int color = ChromaAnimationAPI.GetRGB(0, 255, 0);
        ChromaAnimationAPI.SetKeysColorAllFramesName(baseLayer, keys, keys.Length, color);
        ChromaAnimationAPI.SetChromaCustomFlagName(baseLayer, true);
        ChromaAnimationAPI.SetChromaCustomColorAllFramesName(baseLayer);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect43ChromaLink()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(64, 0, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect43Headset()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_Headset.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(64, 0, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect43Mousepad()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(64, 0, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect43Mouse()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(64, 0, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect43Keypad()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keypad.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(64, 0, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect44()
    {
        string baseLayer = "Animations/Spiral_Keyboard.chroma";
        string layer2 = "animations/Rainbow_Keyboard.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.CloseAnimationName(layer2);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.GetAnimation(layer2);
        int color1 = ChromaAnimationAPI.GetRGB(32, 32, 32);
        int color2 = ChromaAnimationAPI.GetRGB(64, 64, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        int[] keys = {
(int)Keyboard.RZKEY.RZKEY_W,
(int)Keyboard.RZKEY.RZKEY_A,
(int)Keyboard.RZKEY.RZKEY_S,
(int)Keyboard.RZKEY.RZKEY_D,
(int)Keyboard.RZKEY.RZKEY_P,
(int)Keyboard.RZKEY.RZKEY_M,
(int)Keyboard.RZKEY.RZKEY_F1,
};
        ChromaAnimationAPI.CopyKeysColorAllFramesName(layer2, baseLayer, keys, keys.Length);
        ChromaAnimationAPI.SetChromaCustomFlagName(baseLayer, true);
        ChromaAnimationAPI.SetChromaCustomColorAllFramesName(baseLayer);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect44ChromaLink()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(32, 32, 32);
        int color2 = ChromaAnimationAPI.GetRGB(64, 64, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect44Headset()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_Headset.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(32, 32, 32);
        int color2 = ChromaAnimationAPI.GetRGB(64, 64, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect44Mousepad()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(32, 32, 32);
        int color2 = ChromaAnimationAPI.GetRGB(64, 64, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect44Mouse()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(32, 32, 32);
        int color2 = ChromaAnimationAPI.GetRGB(64, 64, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect44Keypad()
    {
        string baseLayer = "Animations/BlackAndWhiteRainbow_Keypad.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
        int color1 = ChromaAnimationAPI.GetRGB(32, 32, 32);
        int color2 = ChromaAnimationAPI.GetRGB(64, 64, 64);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect45()
    {
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 120;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 64, 64, 64);
        int[] keys = {
(int)Keyboard.RZKEY.RZKEY_W,
(int)Keyboard.RZKEY.RZKEY_A,
(int)Keyboard.RZKEY.RZKEY_S,
(int)Keyboard.RZKEY.RZKEY_D,
};
        ChromaAnimationAPI.SetKeysColorAllFramesRGBName(baseLayer, keys, keys.Length, 255, 255, 0);
        keys = new int[] {
(int)Keyboard.RZKEY.RZKEY_F1,
(int)Keyboard.RZKEY.RZKEY_F2,
(int)Keyboard.RZKEY.RZKEY_F3,
(int)Keyboard.RZKEY.RZKEY_F4,
(int)Keyboard.RZKEY.RZKEY_F5,
(int)Keyboard.RZKEY.RZKEY_F6,
};
        float t = 0;
        float speed = 0.05f;
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            t += speed;
            float hp = Mathf.Abs(Mathf.Cos(Mathf.PI / 2.0f + t));
            for (int i = 0; i < keys.Length; ++i)
            {
                int color = ChromaAnimationAPI.GetRGB(0, (int)(255 * (1 - hp)), 0);
                if ((i + 1) / (float)(keys.Length + 1) < hp)
                {
                    color = ChromaAnimationAPI.GetRGB(0, 255, 0);
                }
                else
                {
                    color = ChromaAnimationAPI.GetRGB(0, 100, 0);
                }
                int key = keys[i];
                ChromaAnimationAPI.SetKeyColorName(baseLayer, frameId, key, color);
            }
        }
        ChromaAnimationAPI.SetChromaCustomFlagName(baseLayer, true);
        ChromaAnimationAPI.SetChromaCustomColorAllFramesName(baseLayer);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect45ChromaLink()
    {
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 50;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, frameCount / 2);
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, frameCount / 2);
        int color1 = ChromaAnimationAPI.GetRGB(0, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect45Headset()
    {
        string baseLayer = "Animations/Blank_Headset.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 50;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, frameCount / 2);
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, frameCount / 2);
        int color1 = ChromaAnimationAPI.GetRGB(0, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect45Mousepad()
    {
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 50;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, frameCount / 2);
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, frameCount / 2);
        int color1 = ChromaAnimationAPI.GetRGB(0, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect45Mouse()
    {
        string baseLayer = "Animations/Blank_Mouse.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 50;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, frameCount / 2);
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, frameCount / 2);
        int color1 = ChromaAnimationAPI.GetRGB(0, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect45Keypad()
    {
        string baseLayer = "Animations/Blank_Keypad.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 50;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, frameCount / 2);
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, frameCount / 2);
        int color1 = ChromaAnimationAPI.GetRGB(0, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect46()
    {
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 120;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 64, 64, 64);
        int[] keys = {
(int)Keyboard.RZKEY.RZKEY_W,
(int)Keyboard.RZKEY.RZKEY_A,
(int)Keyboard.RZKEY.RZKEY_S,
(int)Keyboard.RZKEY.RZKEY_D,
};
        ChromaAnimationAPI.SetKeysColorAllFramesRGBName(baseLayer, keys, keys.Length, 255, 0, 0);
        keys = new int[] {
(int)Keyboard.RZKEY.RZKEY_F7,
(int)Keyboard.RZKEY.RZKEY_F8,
(int)Keyboard.RZKEY.RZKEY_F9,
(int)Keyboard.RZKEY.RZKEY_F10,
(int)Keyboard.RZKEY.RZKEY_F11,
(int)Keyboard.RZKEY.RZKEY_F12,
};
        float t = 0;
        float speed = 0.05f;
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            t += speed;
            float hp = Mathf.Abs(Mathf.Cos(Mathf.PI / 2.0f + t));
            for (int i = 0; i < keys.Length; ++i)
            {
                int color = ChromaAnimationAPI.GetRGB((int)(255 * (1 - hp)), (int)(255 * (1 - hp)), 0);
                if ((i + 1) / (float)(keys.Length + 1) < hp)
                {
                    color = ChromaAnimationAPI.GetRGB(255, 255, 0);
                }
                else
                {
                    color = ChromaAnimationAPI.GetRGB(100, 100, 0);
                }
                int key = keys[i];
                ChromaAnimationAPI.SetKeyColorName(baseLayer, frameId, key, color);
            }
        }
        ChromaAnimationAPI.SetChromaCustomFlagName(baseLayer, true);
        ChromaAnimationAPI.SetChromaCustomColorAllFramesName(baseLayer);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect46ChromaLink()
    {
        string baseLayer = "Animations/Blank_ChromaLink.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 50;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, frameCount / 2);
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, frameCount / 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 255, 0);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect46Headset()
    {
        string baseLayer = "Animations/Blank_Headset.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 50;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, frameCount / 2);
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, frameCount / 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 255, 0);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect46Mousepad()
    {
        string baseLayer = "Animations/Blank_Mousepad.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 50;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, frameCount / 2);
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, frameCount / 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 255, 0);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect46Mouse()
    {
        string baseLayer = "Animations/Blank_Mouse.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 50;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, frameCount / 2);
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, frameCount / 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 255, 0);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowEffect46Keypad()
    {
        string baseLayer = "Animations/Blank_Keypad.chroma";
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int frameCount = 50;
        ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
        ChromaAnimationAPI.FadeStartFramesName(baseLayer, frameCount / 2);
        ChromaAnimationAPI.FadeEndFramesName(baseLayer, frameCount / 2);
        int color1 = ChromaAnimationAPI.GetRGB(64, 64, 0);
        int color2 = ChromaAnimationAPI.GetRGB(255, 255, 0);
        ChromaAnimationAPI.MultiplyTargetColorLerpAllFramesName(baseLayer, color1, color2);
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    #endregion

}
