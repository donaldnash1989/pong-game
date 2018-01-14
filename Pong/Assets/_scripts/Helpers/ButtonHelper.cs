using UnityEngine;

public class ButtonHelper : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadGameSummary();
            ShowAndUnlockCursor();
        }
    }

    public void LoadGame()
    {
        GameManager.GameScene();
    }

    public void LoadMainMenu()
    {
        GameManager.MainMenuScene();
    }

    public void LoadGameSummary()
    {
        GameManager.GameSummaryScene();
    }

    public void HideAndLockCursor()
    {
        CursorManager.HideAndLockCursor();
    }

    public void ShowAndUnlockCursor()
    {
        CursorManager.ShowAndUnlockCursor();
    }
}
