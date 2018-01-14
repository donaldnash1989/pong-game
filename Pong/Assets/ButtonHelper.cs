using UnityEngine;

public class ButtonHelper : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            GameManager.GameSummaryScene();
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
}
