using UnityEngine;

public class Ball : MonoBehaviour {

    private Vector3 velocity;
    public float yBound = 18;

    public AudioClip hit, die;
	
	void Update () {

        if(transform.position.y > yBound || transform.position.y < -yBound)
        {
            velocity.y *= -1;
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

            //Spawn next ball at player two spawn
            GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>().SpawnBall(2);

            //Play death sound
            AudioManager.PlaySoundEffect(die);

            //Destroy this ball
            Destroy(gameObject);
        }

        if (other.tag.Equals("PlayerOneGoal"))
        {
            //Add to player one score
            ScoreManager.AddPlayerOneScore();

            //Spawn next ball at player one spawn
            GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>().SpawnBall(1);

            //Play death sound
            AudioManager.PlaySoundEffect(die);

            //Destroy this ball
            Destroy(gameObject);
        }
    }
}
