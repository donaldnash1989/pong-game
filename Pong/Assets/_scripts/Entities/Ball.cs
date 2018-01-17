using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    private Vector3 velocity;
    public float yBound = 18;
    public GameObject wallHitParticlePrefab;
    public GameObject deathParticlePrefab;

    public AudioClip hit, die;
	
	void Update () {

        if(transform.position.y > yBound || transform.position.y < -yBound)
        {
            velocity.y *= -1;
            Instantiate(wallHitParticlePrefab, transform.position, Quaternion.identity);
            AudioManager.PlaySoundEffect(hit);
        }
        transform.position += velocity;
	}

    public void SetVelocity(Vector3 v)
    {
        velocity = v;
    }

    public Vector3 GetVelocity()
    {
        return velocity;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Paddle"))
        {
            //Reverse the velocity
            velocity.x *= -1;

            //slightly modify the y velocity based on where it was hit
            float part =  transform.position.y - other.transform.position.y;
            velocity.y += (part/10.0f);

            //Play hit sound
            AudioManager.PlaySoundEffect(hit);
        }

        if (other.tag.Equals("PlayerTwoGoal"))
        {
            //Add to player two score
            ScoreManager.AddPlayerTwoScore();

            //Set serve turn
            ScoreManager.SetTurn(2);

            //prep next ball
            NextBall();
        }

        if (other.tag.Equals("PlayerOneGoal"))
        {
            //Add to player two score
            ScoreManager.AddPlayerOneScore();

            //Set serve turn
            ScoreManager.SetTurn(1);

            //prep next ball
            NextBall();
        }
    }

    private void NextBall()
    {
        CameraController.Shake();

        //Enable serve button
        GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>().EnableServe();

        //Play death sound
        AudioManager.PlaySoundEffect(die);

        //Create death particle effect
        Instantiate(deathParticlePrefab, transform.position, Quaternion.identity);

        //Destroy this ball
        Destroy(gameObject);
    }
}
