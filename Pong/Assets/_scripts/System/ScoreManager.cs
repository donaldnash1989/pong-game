using UnityEngine;

public class ScoreManager : MonoBehaviour {

    private static int playerOneScore;
    private static int playerTwoScore;

    void Update()
    {
        if(playerOneScore >= 10 || playerTwoScore >= 10)
        {
            GameManager.GameSummaryScene();
            CursorManager.ShowAndUnlockCursor();
        }
    }

    public static void AddPlayerOneScore()
    {
        playerOneScore++;
    }

    public static void AddPlayerTwoScore()
    {
        playerTwoScore++;
    }

    public static int GetPlayerOneScore()
    {
        return playerOneScore;
    }

    public static int GetPlayerTwoScore()
    {
        return playerTwoScore;
    }

    public static void ResetScores()
    {
        playerOneScore = playerTwoScore = 0;
    }
}
