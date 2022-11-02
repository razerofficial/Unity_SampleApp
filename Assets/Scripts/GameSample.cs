using ChromaSDK;
using System;
using System.Collections;
using UnityEngine;

public class GameSample : MonoBehaviour
{
    private const int MAX_EFFECTS = 15;

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

    public IEnumerator Start()
    {
        if (!ChromaAnimationAPI.IsChromaSDKAvailable())
        {
            _mResult = RazerErrors.RZRESULT_DLL_NOT_FOUND;
            yield break;
        }

        ChromaAnimationAPI._sStreamingAssetPath = Application.streamingAssetsPath;

        ChromaSDK.APPINFOTYPE appInfo = new APPINFOTYPE();
        appInfo.Title = "Razer Chroma Unity Game Sample Application";
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
        appInfo.SupportedDevice = (0x01 | 0x02 | 0x04 | 0x08 | 0x10 | 0x20);
        //    0x01 | // Utility. (To specifiy this is an utility application)
        //    0x02   // Game. (To specifiy this is a game);
        appInfo.Category = 1;
        _mResult = ChromaAnimationAPI.InitSDK(ref appInfo);
        switch (_mResult)
        {
            case RazerErrors.RZRESULT_DLL_NOT_FOUND:
                Debug.Log(string.Format("Chroma DLL is not found! {0}", RazerErrors.GetResultString(_mResult)));
                break;
            case RazerErrors.RZRESULT_DLL_INVALID_SIGNATURE:
                Debug.Log(string.Format("Chroma DLL has an invalid signature! {0}", RazerErrors.GetResultString(_mResult)));
                break;
            case RazerErrors.RZRESULT_SUCCESS:
                _mInitialized = true;
                _mSupportsStreaming = ChromaAnimationAPI.CoreStreamSupportsStreaming();
                yield return new WaitForSeconds(0.1f);
                break;
            default:
                // If Chroma is not supported on the system, just avoid making further calls to the API until next time
                Debug.Log(string.Format("Failed to initialize Chroma! {0}", RazerErrors.GetResultString(_mResult)));
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
#if !UNITY_EDITOR
            ChromaAnimationAPI.UninitAPI();
#endif
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
                                    GUILayout.Label("UNITY GAME CHROMA SAMPLE APP");
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

                                        for (int index = 0; index <= MAX_EFFECTS / 2; ++index)
                                        {
                                            if (GUILayout.Button(GetEffectName(index + 1), GUILayout.Height(buttonHeight)))
                                            {
                                                ExecuteItem(index + 1);
                                            }
                                        }

                                        GUILayout.FlexibleSpace();
                                    }
                                    GUILayout.EndVertical();

                                    GUILayout.FlexibleSpace();

                                    // sample section
                                    GUILayout.BeginVertical();
                                    {
                                        GUILayout.FlexibleSpace();

                                        for (int index = MAX_EFFECTS / 2 + 1; index < MAX_EFFECTS; ++index)
                                        {
                                            if (GUILayout.Button(GetEffectName(index + 1), GUILayout.Height(buttonHeight)))
                                            {
                                                ExecuteItem(index + 1);
                                            }
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
