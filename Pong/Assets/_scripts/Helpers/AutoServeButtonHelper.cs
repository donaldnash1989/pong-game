using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoServeButtonHelper : MonoBehaviour {

    public Sprite blank, notIcon;
    private bool runOnce = false;

    void Update()
    {
        if (!runOnce)
        {
            if (Convert.IntToBool(PlayerPrefs.GetInt("AutoServe")))
            {
                GetComponent<Image>().sprite = blank;
            }
            else
            {
                GetComponent<Image>().sprite = notIcon;
            }
            runOnce = true;
        }
    }

    public void ToggleAutoServe()
    {
        if (Convert.IntToBool(PlayerPrefs.GetInt("AutoServe")))
        {
            PlayerPrefs.SetInt("AutoServe", 0);
            GetComponent<Image>().sprite = notIcon;
        }
        else
        {
            PlayerPrefs.SetInt("AutoServe", 1);
            GetComponent<Image>().sprite = blank;
        }
    }
}
