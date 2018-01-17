using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class intro2 : MonoBehaviour {

    public TextMeshProUGUI introText;
    public TextMeshProUGUI introText2;
    public Image image;
    private string str;
    private bool boolean = false;
    
    void Start()
    {
        if (GameManager.firstPlay)
        {
            GameObject.Find("GameManager").GetComponent<IntroManager>().ServeIntro(introText);
        }
        else
        {
            image.enabled = false;
        }
    }

    void Update()
    {
        if (GameManager.firstPlay)
        {
            if (!boolean && ScoreManager.GetPlayerOneScore() + ScoreManager.GetPlayerTwoScore() == 1)
            {
                boolean = true;
                IconsIntro();
            }
        }
    }

    public void IconsIntro()
    {
        if (GameManager.firstPlay)
        {
            image.enabled = false;
            GameObject.Find("GameManager").GetComponent<IntroManager>().IconsIntro(introText2);
            PlayerPrefs.SetInt("FirstPlay", 1);
        }
    }

    public void Clear()
    {
        GameObject.Find("GameManager").GetComponent<IntroManager>().Clear(introText);
        GameObject.Find("GameManager").GetComponent<IntroManager>().Clear(introText2);
    }
}
