using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject ballPrefab;
    public Transform playerOneSpawn;
    public Transform playerTwoSpawn;

    void Start () {
        GameObject ballReference = Instantiate(ballPrefab, playerOneSpawn.position, Quaternion.identity);
        ballReference.GetComponent<Ball>().SetVelocity(new Vector3(0.1f, Random.Range(0, 2) == 0 ? -0.1f : 0.1f, 0.0f));
	}
	
	void Update () {
		
	}

    public void SpawnBall(int player)
    {
        GameObject ballReference = null;
        switch (player)
        {
            case 1:
                ballReference = Instantiate(ballPrefab, playerOneSpawn.position, Quaternion.identity);
                ballReference.GetComponent<Ball>().SetVelocity(new Vector3(0.1f, Random.Range(0, 2) == 0 ? -0.1f : 0.1f, 0.0f));
                return;
            case 2:
                ballReference = Instantiate(ballPrefab, playerTwoSpawn.position, Quaternion.identity);
                ballReference.GetComponent<Ball>().SetVelocity(new Vector3(-0.1f, Random.Range(0, 2) == 0 ? -0.1f : 0.1f, 0.0f));
                return;
            default:
                throw new System.Exception("Not a player spawn point");
        }
    }
}
