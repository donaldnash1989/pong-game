using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDHelper : MonoBehaviour {

    public TextMeshProUGUI playerOneScoreReadout;
    public TextMeshProUGUI playerTwoScoreReadout;

    void Update () {
        playerOneScoreReadout.text = "" + ScoreManager.GetPlayerOneScore();
        playerTwoScoreReadout.text = "" + ScoreManager.GetPlayerTwoScore();
    }
}
