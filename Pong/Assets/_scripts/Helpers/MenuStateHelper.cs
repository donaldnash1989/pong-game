using UnityEngine;

public class MenuStateHelper : MonoBehaviour {

    public Canvas[] menus;
    
	void Start () {
        foreach (Canvas menu in menus)
        {
            menu.enabled = false;
        }
	}
}
