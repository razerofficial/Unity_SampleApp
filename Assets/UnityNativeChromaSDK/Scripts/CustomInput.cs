using System.Runtime.InteropServices;
using UnityEngine;

namespace ChromaSDK
{
    public class CustomInput
    {
#if UNITY_2017 && PLATFORM_XBOXONE && !UNITY_EDITOR
    const string DLL_NAME = "XDKChromaEditorLibrary";

    public const int SUCCESS = 0;
    public const int FAILURE = -1;

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
    private static extern int PluginInitializeCursor();

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
    public static extern int PluginUninitializeCursor();

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
    public static extern int PluginGetAbsoluteCursorPosition(out float x, out float y, out float z);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
    public static extern int PluginGetCursorButton(int button, out bool result);

    static CustomInput()
    {
        if (SUCCESS != PluginInitializeCursor())
        {
            Debug.LogError("Failed to initialize cursor!");
        }
    }
#endif

        public static Vector3 mousePosition
        {
            get
            {
#if UNITY_2017 && PLATFORM_XBOXONE && !UNITY_EDITOR
                Vector3 result;
                float x,y,z;
                if (SUCCESS == PluginGetAbsoluteCursorPosition(out x, out y, out z))
                {
                    result.x = x;
                    result.y = Screen.height - y; //invert
                    result.z = z;
                    return result;
                }
                else
                {
                    return Vector3.zero;
                }
#else
                return Input.mousePosition;
#endif
            }
        }

        public static bool GetMouseButton(int button)
        {
#if UNITY_2017 && PLATFORM_XBOXONE && !UNITY_EDITOR
            bool result;
            if (SUCCESS == PluginGetCursorButton(button, out result))
            {
                return result;
            }
            return false;
#else
            return Input.GetMouseButton(button);
#endif
        }
    }
}
