using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnePaddle : MonoBehaviour, IInputListener {

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

        position.y = Mathf.Clamp(newy, -18, 18);
        transform.position = position;
    }

    public void OnDestroy()
    {
        InputHandler.GetInstance().Unregister(this);
    }
}
