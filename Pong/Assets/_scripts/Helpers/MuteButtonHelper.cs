using UnityEngine;
using UnityEngine.UI;

public class MuteButtonHelper : MonoBehaviour
{
    public Sprite unmute, mute;
    private bool runOnce = false;
	
	void Update ()
    {
        if (!runOnce)
        {
            if (!AudioManager.IsMuted())
            {
                GetComponent<Image>().sprite = unmute;
            }
            else
            {
                GetComponent<Image>().sprite = mute;
            }
            runOnce = true;
        }
    }

    public void ToggleMute()
    {
        if (AudioManager.IsMuted())
        {
            AudioManager.UnMute();
            GetComponent<Image>().sprite = unmute;
        }
        else
        {
            AudioManager.Mute();
            GetComponent<Image>().sprite = mute;
        }
    }
}
