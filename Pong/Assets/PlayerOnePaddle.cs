using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnePaddle : MonoBehaviour, IInputListener {

    public float yBound = 18.0f;

    void Awake()
    {
        InputHandler.GetInstance().Register(this);
    }

    void Start () {
		
	}
	
	void Update () {

    }

    public void mouseDeltaYChanged(float amount)
    {
        Vector3 position = transform.position;
        float newy = position.y + amount;

        position.y = Mathf.Clamp(newy, -yBound, yBound);
        transform.position = position;
    }

    public void OnDestroy()
    {
        InputHandler.GetInstance().Unregister(this);
    }
}
