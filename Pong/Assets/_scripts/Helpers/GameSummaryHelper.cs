using TMPro;
using UnityEngine;

public class GameSummaryHelper : MonoBehaviour {

    public TextMeshProUGUI winnerReadout;

	void Start () {
        int playerOneScore = ScoreManager.GetPlayerOneScore();
        int playerTwoScore = ScoreManager.GetPlayerTwoScore();
        int winner = playerOneScore > playerTwoScore ? 1 : 2;
        winnerReadout.text = "Player " + winner + " Wins!";
        ScoreManager.ResetScores();
    }
}
