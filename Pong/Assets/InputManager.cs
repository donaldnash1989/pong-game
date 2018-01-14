using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	void Update () {
		if(Input.GetAxis("Mouse Y") != 0)
        {
            InputHandler.GetInstance().Notify(Input.GetAxis("Mouse Y"));
        }
	}
}
