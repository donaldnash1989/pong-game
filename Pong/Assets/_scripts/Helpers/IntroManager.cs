using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroManager : MonoBehaviour {
    
    private string str;

    public void Intro(TextMeshProUGUI t)
    {
        str = "To get started, hit 'PLAY.'";
        StartCoroutine(DisplayMessage(t));
    }

    public void DifficultyIntro(TextMeshProUGUI t)
    {
        StopAllCoroutines();
        str = "Now select a difficulty.";
        StartCoroutine(DisplayMessage(t));
    }

    public void ServeIntro(TextMeshProUGUI t)
    {
        StopAllCoroutines();
        str = "Hit 'Serve' to begin.";
        StartCoroutine(DisplayMessage(t));
    }

    public void IconsIntro(TextMeshProUGUI t)
    {
        StopAllCoroutines();
        str = "Use the 'Auto' icon to auto-serve, use the speaker icon to turn off sounds";
        StartCoroutine(DisplayMessage(t));
    }

    public void Clear(TextMeshProUGUI t)
    {
        StopAllCoroutines();
        t.text = "";
    }

    IEnumerator DisplayMessage(TextMeshProUGUI t)
    {
        t.text = "";
        float delay = 0.02f;
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (c == ' ') delay = 0.2f;
            else delay = 0.05f;
            delay = Random.Range(0.05f, 0.1f);
            yield return new WaitForSeconds(delay);
            t.text += c;
        }
    }
}
