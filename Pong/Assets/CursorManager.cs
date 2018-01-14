using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour {

    public static void HideCursor()
    {
        Cursor.visible = false;
    }

    public static void HideAndLockCursor()
    {
        HideCursor();
        Cursor.lockState = CursorLockMode.Locked;
    }

    public static void ShowCursor()
    {
        Cursor.visible = true;
    }

    public static void ShowAndUnlockCursor()
    {
        ShowCursor();
        Cursor.lockState = CursorLockMode.None;
    }

}
