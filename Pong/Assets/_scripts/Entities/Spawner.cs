using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject ballPrefab;
    public Transform playerOneSpawn;
    public Transform playerTwoSpawn;
    private float ballSpeed = 0.5f;

    void Start () {
        ballSpeed = DifficultyManager.GetBallSpeed();
        GameObject ballReference = Instantiate(ballPrefab, playerOneSpawn.position, Quaternion.identity);
        ballReference.GetComponent<Ball>().SetVelocity(new Vector3(ballSpeed, Random.Range(-0.5f, 0.5f)));
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
                ballReference.GetComponent<Ball>().SetVelocity(new Vector3(ballSpeed, Random.Range(-0.5f, 0.5f)));
                return;
            case 2:
                ballReference = Instantiate(ballPrefab, playerTwoSpawn.position, Quaternion.identity);
                ballReference.GetComponent<Ball>().SetVelocity(new Vector3(-ballSpeed, Random.Range(-0.5f, 0.5f)));
                return;
            default:
                throw new System.Exception("Not a player spawn point");
        }
    }
}
