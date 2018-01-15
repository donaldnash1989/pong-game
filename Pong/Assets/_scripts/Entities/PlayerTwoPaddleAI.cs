using System.Collections;
using UnityEngine;

public class PlayerTwoPaddleAI : MonoBehaviour {

    private GameObject ball;
    public float yBound = 18.0f;
    private float speed = 1.0f;
    private float detectionRange = 0.0f;

    bool newWander = false;
    private float wanderAmount;

    void Start()
    {
        speed = DifficultyManager.GetPaddleSpeed();
        detectionRange = DifficultyManager.GetDetectionRange();
    }

    void Update ()
    {
        Vector3 position = transform.position;

        if (ball == null)
        {
            ball = GameObject.Find("Ball(Clone)");
            position = Wandering(position);
        }
        else
        {
            float yPos = position.y;
            float yBall = ball.transform.position.y;
            if (ball.transform.position.x > -detectionRange && ball.GetComponent<Ball>().GetVelocity().x > 0)
            {
                float yDist = ((yBall + yBound) - (yPos + yBound));

                float newy = position.y + (yDist / Mathf.Abs(yDist)) * Time.deltaTime * speed;

                if ((yDist > 1.5f || yDist < -1.5f) && (newy > -yBound && newy < yBound))
                {
                    position.y = newy;
                }
            }
            else
            {
                position = Wandering(position);
            }
        }

        transform.position = position;
    }

    private Vector3 Wandering(Vector3 position)
    {
        if (!newWander)
        {
            StartCoroutine(Wander());
        }

        float newy = position.y + wanderAmount;
        position.y = Mathf.Clamp(newy, -yBound, yBound);
        return position;
    }

    IEnumerator Wander()
    {
        newWander = true;
        wanderAmount = (Random.Range(-1, 2) * Time.deltaTime) * speed;
        yield return new WaitForSeconds(0.2f);
        newWander = false;
    }
}
