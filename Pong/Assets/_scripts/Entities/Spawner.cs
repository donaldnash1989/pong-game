using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

    public GameObject ballPrefab;
    public Transform playerOneSpawn;
    public Transform playerTwoSpawn;
    private float ballSpeed = 0.5f;
    public Canvas spawnButton;

    void Start () {
        ballSpeed = DifficultyManager.GetBallSpeed();
	}
	
	void Update () {
		
	}

    public void SpawnBall(int player)
    {
        StartCoroutine(Spawn());
        spawnButton.enabled = false;
    }

    IEnumerator Spawn()
    {
        int player = ScoreManager.GetTurn();
        yield return new WaitForSeconds(1.0f);
        GameObject ballReference = null;
        switch (player)
        {
            case 1:
                ballReference = Instantiate(ballPrefab, playerOneSpawn.position, Quaternion.identity);
                ballReference.GetComponent<Ball>().SetVelocity(new Vector3(ballSpeed, Random.Range(-0.5f, 0.5f)));
                break;
            case 2:
                ballReference = Instantiate(ballPrefab, playerTwoSpawn.position, Quaternion.identity);
                ballReference.GetComponent<Ball>().SetVelocity(new Vector3(-ballSpeed, Random.Range(-0.5f, 0.5f)));
                break;
            default:
                throw new System.Exception("Not a player spawn point");
        }
    }

    public void EnableServe()
    {
        if (Convert.IntToBool(PlayerPrefs.GetInt("AutoServe")))
        {
            StartCoroutine(Spawn());
        }
        else
        {
            spawnButton.enabled = true;

            //free up the players mouse
            CursorManager.ShowAndUnlockCursor();
        }
    }


}
