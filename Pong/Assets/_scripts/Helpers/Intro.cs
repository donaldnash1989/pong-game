using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Intro : MonoBehaviour {

    public TextMeshProUGUI introText;
    public Image image;
    private string str;
    private bool boolean = false;

	void Start ()
    {
        if(GameManager.firstPlay)
        {
            PlayerPrefs.SetInt("AutoServe", 0);
            GameObject.Find("GameManager").GetComponent<IntroManager>().Intro(introText);
        }
        else
        {
            image.enabled = false;
        }
    }
	
	public void DifficultyIntro()
    {
        if (GameManager.firstPlay)
        {
            GameObject.Find("GameManager").GetComponent<IntroManager>().DifficultyIntro(introText);
        }
    }
}
