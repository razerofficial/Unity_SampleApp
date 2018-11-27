using ChromaSDK;
using System;
using UnityEngine;

public class SampleApp : MonoBehaviour
{
    public void Start()
    {
        ChromaAnimationAPI.Init();
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
                ShowTableEffect1();
                break;
            case 2:
                ShowTableEffect2();
                break;
            case 3:
                ShowTableEffect3();
                break;
            case 4:
                ShowTableEffect4();
                break;
            case 5:
                ShowTableEffect5();
                break;
            case 6:
                ShowTableEffect6();
                break;
            case 7:
                ShowTableEffect7();
                break;
            case 8:
                ShowTableEffect8();
                break;
            case 9:
                ShowTableEffect9();
                break;
            case 10:
                ShowTableEffect10();
                break;
            case 11:
                ShowTableEffect11();
                break;
            case 12:
                ShowTableEffect12();
                break;
            case 13:
                ShowTableEffect13();
                break;
            case 14:
                ShowTableEffect14();
                break;
            case 15:
                ShowTableEffect15();
                break;
            case 16:
                ShowTableEffect16();
                break;
            case 17:
                ShowTableEffect17();
                break;
            case 18:
                ShowTableEffect18();
                break;
            case 19:
                ShowTableEffect19();
                break;
            case 20:
                ShowTableEffect20();
                break;
            case 21:
                ShowTableEffect21();
                break;
            case 22:
                ShowTableEffect22();
                break;
            case 23:
                ShowTableEffect23();
                break;
            case 24:
                ShowTableEffect24();
                break;
            case 25:
                ShowTableEffect25();
                break;
            case 26:
                ShowTableEffect26();
                break;
            case 27:
                ShowTableEffect27();
                break;
            case 28:
                ShowTableEffect28();
                break;
            case 29:
                ShowTableEffect29();
                break;
            case 30:
                ShowTableEffect30();
                break;
            case 31:
                ShowTableEffect31();
                break;
            case 32:
                ShowTableEffect32();
                break;
            case 33:
                ShowTableEffect33();
                break;
            case 34:
                ShowTableEffect34();
                break;
            case 35:
                ShowTableEffect35();
                break;
            case 36:
                ShowTableEffect36();
                break;
            case 37:
                ShowTableEffect37();
                break;
            case 38:
                ShowTableEffect38();
                break;
            case 39:
                ShowTableEffect39();
                break;
        }
    }

    public void OnGUI()
    {
        GUILayout.FlexibleSpace();
        GUILayout.BeginHorizontal(GUILayout.Width(Screen.width));
        GUILayout.FlexibleSpace();

        const float height = 40;

        for (int index = 1; index < 40; ++index)
        {
            if (ShowHeader(index))
            {
                GUILayout.BeginVertical(GUILayout.Height(Screen.height));
                GUILayout.FlexibleSpace();
            }

            if (GUILayout.Button(GetEffectName(index), GUILayout.Height(height)))
            {
                ExecuteItem(index);
            }

            if (ShowFooter(index))
            {
                GUILayout.FlexibleSpace();
                GUILayout.EndVertical();
            }

        }

        GUILayout.FlexibleSpace();        
        GUILayout.EndHorizontal();
        GUILayout.FlexibleSpace();
    }

    // autogenerated code

    void ShowTableEffect1()
    {
        // start with a blank animation
        string baseLayer = "animations/Sprite1_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect2()
    {
        // start with a blank animation
        string baseLayer = "Animations/Tongue1_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect3()
    {
        // start with a blank animation
        string baseLayer = "Animations/Tongue1_Keyboard.chroma";
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
    void ShowTableEffect4()
    {
        // start with a blank animation
        string baseLayer = "Animations/OutParticle1_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect5()
    {
        // start with a blank animation
        string baseLayer = "Animations/OutParticle1_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // turn grayscale particles to blue water
        ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect6()
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
    void ShowTableEffect7()
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
    void ShowTableEffect8()
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
    void ShowTableEffect9()
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
        int speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
            float t = 1 - (float)(float)Math.Floor(Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount));
            // multiply the frame by the 't' intensity
            ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect10()
    {
        // start with a blank animation
        string baseLayer = "Animations/Clouds1_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect11()
    {
        // start with a blank animation
        string baseLayer = "Animations/Clouds1_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // reduce the intensity of the layer
        ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect12()
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
    void ShowTableEffect13()
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
    void ShowTableEffect14()
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
    void ShowTableEffect15()
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
        int speed = 2;
        // loop over all frames in the layer
        for (int frameId = 0; frameId < frameCount; ++frameId)
        {
            //Math.cos gives a smooth 1 to 0 to 1 curve
            float t = (float)Math.Floor(Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount));
            // use t to transition from color 1 to color 2
            int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
            // give color to the layer
            ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
        }
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect16()
    {
        // start with a blank animation
        string baseLayer = "Animations/Tongue1_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect17()
    {
        // start with a blank animation
        string baseLayer = "Animations/Tongue1_Keyboard.chroma";
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
    void ShowTableEffect18()
    {
        // start with a blank animation
        string baseLayer = "Animations/Tongue1_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        int threshold = 50;
        ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect19()
    {
        // start with a blank animation
        string baseLayer = "Animations/Tongue1_Keyboard.chroma";
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
    void ShowTableEffect20()
    {
        // start with a blank animation
        string baseLayer = "Animations/Arc3_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect21()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        string layer2 = "Animations/Arc3_Keyboard.chroma";
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
    void ShowTableEffect22()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        string layer2 = "Animations/Arc3_Keyboard.chroma";
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
    void ShowTableEffect23()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        string layer2 = "Animations/Arc3_Keyboard.chroma";
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
    void ShowTableEffect24()
    {
        // start with a blank animation
        string baseLayer = "Animations/Blank_Keyboard.chroma";
        string layer2 = "Animations/Arc3_Keyboard.chroma";
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
    void ShowTableEffect25()
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
    void ShowTableEffect26()
    {
        // start with a blank animation
        string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect27()
    {
        // start with a blank animation
        string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
        // close the blank animation if it's already loaded, discarding any changes
        ChromaAnimationAPI.CloseAnimationName(baseLayer);
        // open the blank animation, passing a reference to the base animation when loading has completed
        ChromaAnimationAPI.GetAnimation(baseLayer);
        // set animation playback to 30 FPS
        ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
        // play the animation on the dynamic canvas
        ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
    }
    void ShowTableEffect28()
    {
        // start with a blank animation
        string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
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
    void ShowTableEffect29()
    {
        // start with a blank animation
        string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
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
    void ShowTableEffect30()
    {
        // start with a blank animation
        string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
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
    void ShowTableEffect31()
    {
        // start with a blank animation
        string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
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
    void ShowTableEffect32()
    {
        // start with a blank animation
        string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
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
    void ShowTableEffect33()
    {
        // start with a blank animation
        string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
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
    void ShowTableEffect34()
    {
        // start with a blank animation
        string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
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
    void ShowTableEffect35()
    {
        // start with a blank animation
        string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
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
    void ShowTableEffect36()
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
    void ShowTableEffect37()
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
    void ShowTableEffect38()
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
    void ShowTableEffect39()
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

}
