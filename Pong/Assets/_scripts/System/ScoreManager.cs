using UnityEngine;

public class ScoreManager : MonoBehaviour {

    private static int playerOneScore;
    private static int playerTwoScore;
    private static int turn = 1;

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

    public static void SetTurn(int player)
    {
        turn = player;
    }

    public static int GetTurn()
    {
        return turn;
    }
}
