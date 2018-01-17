using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public int numberOfShakes = 5;
    public float shakeDimmer = 20.0f;
    public float shakeSpeed = 0.01f;
    
    private static bool isShake = false;
    private Vector3 currentPos;
    private Vector3 newPosition;

    void Start()
    {
        currentPos = transform.position;
    }

    void Update()
    {
        if (isShake)
        {
            StartCoroutine(Shaking(shakeSpeed));
            isShake = false;
        }
        else
        {
            transform.position = currentPos;
        }
    }

    public static void Shake()
    {
        isShake = true;
    }

    IEnumerator Shaking(float shakeSpeed)
    {
        for (int i = 0; i < numberOfShakes; i++)
        {
            float rx = Random.Range(-2.0f, 2.0f) / shakeDimmer;
            float ry = Random.Range(-2.0f, 2.0f) / shakeDimmer;
            if (rx == 0) rx = -1f / shakeDimmer;
            if (ry == 0) ry = -1f / shakeDimmer;
            newPosition = new Vector3(currentPos.x + rx, currentPos.y + ry, currentPos.z);

            transform.position = newPosition;
            yield return new WaitForSeconds(shakeSpeed);

            transform.position = currentPos;
            yield return new WaitForSeconds(shakeSpeed);
        }
    }
}
