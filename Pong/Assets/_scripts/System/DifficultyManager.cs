using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour {

    private static float ballSpeed;
    private static float detectionRange;
    private static float paddleSpeed;

    public static void SetEasy()
    {
        ballSpeed = 0.4f;
        detectionRange = -2.0f;
        paddleSpeed = 20.0f;
    }

    public static void SetMedium()
    {
        ballSpeed = 0.7f;
        detectionRange = 7.0f;
        paddleSpeed = 30.0f;
    }

    public static void SetHard()
    {
        ballSpeed = 1.0f;
        detectionRange = 15.0f;
        paddleSpeed = 45.0f;
    }

    public static float GetBallSpeed()
    {
        return ballSpeed;
    }

    public static float GetDetectionRange()
    {
        return detectionRange;
    }

    public static float GetPaddleSpeed()
    {
        return paddleSpeed;
    }
}
