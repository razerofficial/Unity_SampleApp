using ChromaSDK;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Chromatic : MonoBehaviour
{
    private int? _mInitResult = null;

    public Button _mButtonX = null;

    public Toggle _mToggleInitChromaSDK = null;
    public TextMeshProUGUI _mLabelInitChromaSDK = null;

    public Button _mButtonIsActive = null;
    public TextMeshProUGUI _mLabelIsActive = null;

    public Button _mButtonIsConnected = null;
    public TextMeshProUGUI _mLabelIsConnected = null;

    public Button _mButtonPlayAnimation = null;
    public TextMeshProUGUI _mLabelPlayAnimation = null;

    public Button _mButtonSetEventName = null;
    public TextMeshProUGUI _mLabelSetEventName = null;

    public Toggle _mToggleUseForward = null;
    public TextMeshProUGUI _mLabelUseForward = null;

    public void OnApplicationQuit()
    {
        if (_mInitResult == RazerErrors.RZRESULT_SUCCESS)
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

    void SetInteractable(bool interactable)
    {
        object[] items =
        {
            _mButtonIsActive,
            _mButtonIsConnected,
            _mButtonPlayAnimation,
            _mButtonSetEventName,
            _mToggleUseForward,
        };
        foreach (object item in items)
        {
            if (item is Button)
            {
                (item as Button).interactable = interactable;
            }
            if (item is Toggle)
            {
                (item as Toggle).interactable = interactable;
            }
        }
    }

    void ShowMessageLabels(bool initialized)
    {
        if (_mLabelIsActive)
        {
            if (initialized)
            {
                _mLabelIsActive.text = "Invoke IsActive() to check for Chroma focus.";
                _mLabelIsActive.color = Color.white;
            }
            else
            {
                _mLabelIsActive.text = "Chroma SDK must be initialized to call IsActive().";
                _mLabelIsActive.color = Color.red;
            }
        }

        if (_mLabelIsConnected)
        {
            if (initialized)
            {
                _mLabelIsConnected.text = "Invoke IsConnected() to check for Chroma devices.";
                _mLabelIsConnected.color = Color.white;
            }
            else
            {
                _mLabelIsConnected.text = "Chroma SDK must be initialized to call IsConnected().";
                _mLabelIsConnected.color = Color.red;
            }
        }

        if (_mLabelPlayAnimation)
        {
            if (initialized)
            {
                _mLabelPlayAnimation.text = "Invoke PlayAnimation() to show Chroma on hardware.";
                _mLabelPlayAnimation.color = Color.white;
            }
            else
            {
                _mLabelPlayAnimation.text = "Chroma SDK must be initialized to call PlayAnimation().";
                _mLabelPlayAnimation.color = Color.red;
            }
        }

        if (_mLabelSetEventName)
        {
            if (initialized)
            {
                _mLabelSetEventName.text = "Invoke SetEventName() to automatically add haptics for Chroma events.";
                _mLabelSetEventName.color = Color.white;
            }
            else
            {
                _mLabelSetEventName.text = "Chroma SDK must be initialized to call SetEventName().";
                _mLabelSetEventName.color = Color.red;
            }
        }

        if (_mLabelUseForward)
        {
            if (initialized)
            {
                _mLabelUseForward.text = "Invoke UseForwardChromaEvents() to toggle automatic calls to SetEventName() from PlayAnimation(). (ON by default)";
                _mLabelUseForward.color = Color.white;
            }
            else
            {
                _mLabelUseForward.text = "Chroma SDK must be initialized to call UseForwardChromaEvents().";
                _mLabelUseForward.color = Color.red;
            }
        }
    }

    void OnCheckInitChromaSDK()
    {
        if (_mToggleInitChromaSDK.isOn)
        {
            APPINFOTYPE appInfo = new APPINFOTYPE();
            appInfo.Title = "Unity Sample Scene - Chromatic";
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

            _mInitResult = ChromaAnimationAPI.InitSDK(ref appInfo);

            if (_mInitResult == RazerErrors.RZRESULT_SUCCESS)
            {
                _mLabelInitChromaSDK.text = "Initialization Success! Ready to use Chroma!";
                _mLabelInitChromaSDK.color = Color.green;
            }
            else
            {
                _mLabelInitChromaSDK.text = "Initialization Failed! Stop using the Chroma SDK until the next game launch!";
                _mLabelInitChromaSDK.color = Color.red;
            }
        }
        else
        {
            if (_mInitResult == RazerErrors.RZRESULT_SUCCESS)
            {
                int result = ChromaAnimationAPI.Uninit();

                if (result == RazerErrors.RZRESULT_SUCCESS)
                {
                    _mLabelInitChromaSDK.text = "Chroma has been uninitialized!";
                    _mLabelInitChromaSDK.color = Color.white;
                    _mInitResult = null;
                }
                else
                {
                    _mLabelInitChromaSDK.text = "Uninitialization was unsuccessful!";
                    _mLabelInitChromaSDK.color = Color.red;
                    _mInitResult = null;
                }
            }
        }

        SetInteractable(_mInitResult == RazerErrors.RZRESULT_SUCCESS);
        ShowMessageLabels(_mInitResult == RazerErrors.RZRESULT_SUCCESS);
    }

    void OnClickIsActive()
    {
        bool isActive;
        int result = ChromaAnimationAPI.CoreIsActive(out isActive);
        if (result == RazerErrors.RZRESULT_SUCCESS)
        {
            if (isActive)
            {
                _mLabelIsActive.text = "This app currently has the Chroma focus!";
                _mLabelIsActive.color = Color.green;
            }
            else
            {
                _mLabelIsActive.text = "The app does not currently have the Chroma focus!";
                _mLabelIsActive.color = Color.red;
            }
        }
        else
        {
            _mLabelIsActive.text = "Unable to check for focus. Unexpected result!";
            _mLabelIsActive.color = Color.red;
        }
    }

    void OnClickIsConnected()
    {
        DEVICE_INFO_TYPE deviceInfo = new DEVICE_INFO_TYPE();
        deviceInfo.DeviceType = 255;
        int result = ChromaAnimationAPI.CoreIsConnected(ref deviceInfo);
        if (result == RazerErrors.RZRESULT_SUCCESS)
        {
            if (deviceInfo.Connected > 0)
            {
                _mLabelIsConnected.text = "Chroma devices are connected!";
                _mLabelIsConnected.color = Color.green;
            }
            else
            {
                _mLabelIsConnected.text = "No Chroma devices are connected!";
                _mLabelIsConnected.color = Color.red;
            }
        }
        else
        {
            _mLabelIsConnected.text = "Unable to check for Chroma devices. Unexpected result!";
            _mLabelIsConnected.color = Color.red;
        }
    }

    void OnClickPlayAnimation()
    {
        string[] devices =
        {
            "ChromaLink",
            "Headset",
            "Keyboard",
            "Keypad",
            "Mouse",
            "Mousepad"
        };
        foreach (string device in devices)
        {
            string animationName = string.Format("Animations/Spiral_{0}.chroma", device);
            ChromaAnimationAPI.PlayAnimationName(animationName, false);
        }

        _mLabelPlayAnimation.text = "Chroma animations are playing!";
        _mLabelPlayAnimation.color = Color.green;
    }

    void OnClickSetEventName()
    {
        int result = ChromaAnimationAPI.CoreSetEventName("Jump_2s");
        if (result == RazerErrors.RZRESULT_SUCCESS)
        {
            _mLabelSetEventName.text = "Chroma event named successfully!";
            _mLabelSetEventName.color = Color.green;
        }
        else
        {
            _mLabelSetEventName.text = "Unable to set event name. Unexpected result!";
            _mLabelSetEventName.color = Color.red;
        }
    }

    void OnCheckUseForwardChromaEvent()
    {
        ChromaAnimationAPI.UseForwardChromaEvents(_mToggleUseForward.isOn);

        if (_mToggleUseForward.isOn)
        {
            _mLabelUseForward.text = "Automatic forward of Chroma events set to ON successfully!";
            _mLabelUseForward.color = Color.green;
        }
        else
        {
            _mLabelUseForward.text = "Automatic forward of Chroma events set to OFF successfully!";
            _mLabelUseForward.color = Color.green;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ChromaAnimationAPI._sStreamingAssetPath = Application.streamingAssetsPath;

        ShowMessageLabels(false);

        if (_mButtonX)
        {
            _mButtonX.onClick.AddListener(delegate
            {
                Application.Quit();
            });
        }

        if (_mToggleInitChromaSDK && _mLabelInitChromaSDK)
        {
            _mToggleInitChromaSDK.onValueChanged.AddListener(delegate
            {
                OnCheckInitChromaSDK();
            });
        }

        if (_mButtonIsActive && _mLabelIsActive)
        {
            _mButtonIsActive.onClick.AddListener(delegate
            {
                OnClickIsActive();
            });
        }

        if (_mButtonIsConnected && _mLabelIsConnected)
        {
            _mButtonIsConnected.onClick.AddListener(delegate
            {
                OnClickIsConnected();
            });
        }

        if (_mButtonPlayAnimation && _mLabelPlayAnimation)
        {
            _mButtonPlayAnimation.onClick.AddListener(delegate
            {
                OnClickPlayAnimation();
            });
        }

        if (_mButtonSetEventName && _mLabelSetEventName)
        {
            _mButtonSetEventName.onClick.AddListener(delegate
            {
                OnClickSetEventName();
            });
        }

        if (_mToggleUseForward && _mLabelUseForward)
        {
            _mToggleUseForward.onValueChanged.AddListener(delegate
            {
                OnCheckUseForwardChromaEvent();
            });
        }
    }
}
