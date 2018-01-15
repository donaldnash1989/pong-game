using UnityEngine;

public class ButtonHelper : MonoBehaviour
{
    public AudioClip clickSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LoadGameSummary();
            ShowAndUnlockCursor();
        }
    }

    public void ExitGame()
    {
        GameManager.ExitGame();
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

    public void SetEasy()
    {
        DifficultyManager.SetEasy();
    }

    public void SetMedium()
    {
        DifficultyManager.SetMedium();
    }

    public void SetHard()
    {
        DifficultyManager.SetHard();
    }

    public void PlayClick()
    {
        AudioManager.PlaySoundEffect(clickSound);
    }
}
