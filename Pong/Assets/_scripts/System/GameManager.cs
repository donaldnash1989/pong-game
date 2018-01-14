using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private static bool isCreated = false;

    void Awake()
    {
        if (isCreated) Destroy(gameObject);
        else
        {
            DontDestroyOnLoad(gameObject);
            isCreated = true;
        }
    }

    public static void ExitGame() { Application.Quit(); }

    public static void MainMenuScene() { SceneManager.LoadScene((int)Scenes.MAIN_MENU); }

    public static void GameScene() { SceneManager.LoadScene((int)Scenes.GAME); }

    public static void GameSummaryScene() { SceneManager.LoadScene((int)Scenes.GAME_SUMMARY); }
}
