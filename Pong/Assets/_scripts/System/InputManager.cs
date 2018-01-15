using UnityEngine;

public class InputManager : MonoBehaviour {

	void Update () {
		if(Input.GetAxis("Mouse Y") != 0)
        {
            InputHandler.GetInstance().NotifyMouseMove(Input.GetAxis("Mouse Y"));
        }
        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
        {
            InputHandler.GetInstance().NotifyCtrlPressed();
        }
	}
}
