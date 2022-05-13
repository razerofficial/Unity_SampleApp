using ChromaSDK;
using UnityEngine;

public class GameSample : MonoBehaviour
{
    private const int MAX_EFFECTS = 15;

    private bool _mInitialized = false;
    private int _mResult = 0;

    public void Start()
    {
        ChromaAnimationAPI._sStreamingAssetPath = Application.streamingAssetsPath;
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
        if (_mResult == RazerErrors.RZRESULT_SUCCESS)
        {
            ChromaAnimationAPI.StopAll();
            ChromaAnimationAPI.CloseAll();
            int result = ChromaAnimationAPI.Uninit();
            ChromaAnimationAPI.UninitAPI();
            if (result != RazerErrors.RZRESULT_SUCCESS)
            {
                Debug.LogError("Failed to uninitialize Chroma!");
            }
        }
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
            case 15:
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

                        for (int index = 1; index <= MAX_EFFECTS; ++index)
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
        }
    }

    #region Autogenerated
    void ShowEffect1()
    {
    }
    void ShowEffect1ChromaLink()
    {
    }
    void ShowEffect1Headset()
    {
    }
    void ShowEffect1Keypad()
    {
    }
    void ShowEffect1Mousepad()
    {
    }
    void ShowEffect1Mouse()
    {
    }
    void ShowEffect2()
    {
    }
    void ShowEffect2ChromaLink()
    {
    }
    void ShowEffect2Headset()
    {
    }
    void ShowEffect2Keypad()
    {
    }
    void ShowEffect2Mousepad()
    {
    }
    void ShowEffect2Mouse()
    {
    }
    void ShowEffect3()
    {
    }
    void ShowEffect3ChromaLink()
    {
    }
    void ShowEffect3Headset()
    {
    }
    void ShowEffect3Keypad()
    {
    }
    void ShowEffect3Mousepad()
    {
    }
    void ShowEffect3Mouse()
    {
    }
    void ShowEffect4()
    {
    }
    void ShowEffect4ChromaLink()
    {
    }
    void ShowEffect4Headset()
    {
    }
    void ShowEffect4Keypad()
    {
    }
    void ShowEffect4Mousepad()
    {
    }
    void ShowEffect4Mouse()
    {
    }
    void ShowEffect5()
    {
    }
    void ShowEffect5ChromaLink()
    {
    }
    void ShowEffect5Headset()
    {
    }
    void ShowEffect5Keypad()
    {
    }
    void ShowEffect5Mousepad()
    {
    }
    void ShowEffect5Mouse()
    {
    }
    void ShowEffect6()
    {
    }
    void ShowEffect6ChromaLink()
    {
    }
    void ShowEffect6Headset()
    {
    }
    void ShowEffect6Keypad()
    {
    }
    void ShowEffect6Mousepad()
    {
    }
    void ShowEffect6Mouse()
    {
    }
    void ShowEffect7()
    {
    }
    void ShowEffect7ChromaLink()
    {
    }
    void ShowEffect7Headset()
    {
    }
    void ShowEffect7Keypad()
    {
    }
    void ShowEffect7Mousepad()
    {
    }
    void ShowEffect7Mouse()
    {
    }
    void ShowEffect8()
    {
    }
    void ShowEffect8ChromaLink()
    {
    }
    void ShowEffect8Headset()
    {
    }
    void ShowEffect8Keypad()
    {
    }
    void ShowEffect8Mousepad()
    {
    }
    void ShowEffect8Mouse()
    {
    }
    void ShowEffect9()
    {
    }
    void ShowEffect9ChromaLink()
    {
    }
    void ShowEffect9Headset()
    {
    }
    void ShowEffect9Keypad()
    {
    }
    void ShowEffect9Mousepad()
    {
    }
    void ShowEffect9Mouse()
    {
    }
    void ShowEffect10()
    {
    }
    void ShowEffect10ChromaLink()
    {
    }
    void ShowEffect10Headset()
    {
    }
    void ShowEffect10Keypad()
    {
    }
    void ShowEffect10Mousepad()
    {
    }
    void ShowEffect10Mouse()
    {
    }
    void ShowEffect11()
    {
    }
    void ShowEffect11ChromaLink()
    {
    }
    void ShowEffect11Headset()
    {
    }
    void ShowEffect11Keypad()
    {
    }
    void ShowEffect11Mousepad()
    {
    }
    void ShowEffect11Mouse()
    {
    }
    void ShowEffect12()
    {
    }
    void ShowEffect12ChromaLink()
    {
    }
    void ShowEffect12Headset()
    {
    }
    void ShowEffect12Keypad()
    {
    }
    void ShowEffect12Mousepad()
    {
    }
    void ShowEffect12Mouse()
    {
    }
    void ShowEffect13()
    {
    }
    void ShowEffect13ChromaLink()
    {
    }
    void ShowEffect13Headset()
    {
    }
    void ShowEffect13Keypad()
    {
    }
    void ShowEffect13Mousepad()
    {
    }
    void ShowEffect13Mouse()
    {
    }
    void ShowEffect14()
    {
    }
    void ShowEffect14ChromaLink()
    {
    }
    void ShowEffect14Headset()
    {
    }
    void ShowEffect14Keypad()
    {
    }
    void ShowEffect14Mousepad()
    {
    }
    void ShowEffect14Mouse()
    {
    }
    void ShowEffect15()
    {
    }
    void ShowEffect15ChromaLink()
    {
    }
    void ShowEffect15Headset()
    {
    }
    void ShowEffect15Keypad()
    {
    }
    void ShowEffect15Mousepad()
    {
    }
    void ShowEffect15Mouse()
    {
    }
    #endregion

}
