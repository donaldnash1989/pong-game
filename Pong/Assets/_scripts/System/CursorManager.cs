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

    public static bool CursorVisible()
    {
        return Cursor.visible;
    }
}
