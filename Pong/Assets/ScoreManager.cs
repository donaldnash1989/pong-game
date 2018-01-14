using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    private static int playerOneScore;
    private static int playerTwoScore;

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
