using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static float BGMVolume;
    public static float SFXVolume;

    private static AudioSource sfxPlayer;
    private static AudioSource bgmPlayer;

    public AudioClip[] bgm;
    public string[] titles;

    public static int currentTrack = 1;

    private static bool isLooping = true;

    private static AudioClip[] _bgm;
    private static string[] _titles;

    void Awake()
    {
        BGMVolume = PlayerPrefs.GetFloat("BGM");
        SFXVolume = PlayerPrefs.GetFloat("SFX");
        _bgm = bgm;
        _titles = titles;
    }

    void Start()
    {
        AudioSource[] sources = GetComponents<AudioSource>();
        sfxPlayer = sources[0];
        bgmPlayer = sources[1];

        bgmPlayer.volume = BGMVolume;
        sfxPlayer.volume = SFXVolume;

        bgmPlayer.mute = Convert.IntToBool(PlayerPrefs.GetInt("Mute"));
        sfxPlayer.mute = Convert.IntToBool(PlayerPrefs.GetInt("Mute"));

        PlayTrack();
    }

    void Update()
    {

        if (!bgmPlayer.isPlaying)
        {
            NextTrack();
        }
    }

    public static void BGMValuChanged(float value)
    {
        BGMVolume = value;
        bgmPlayer.volume = BGMVolume;
    }

    public static void SFXValuChanged(float value)
    {
        SFXVolume = value;
        sfxPlayer.volume = SFXVolume;
    }

    public static void PlaySoundEffect(AudioClip soundEffect)
    {
        sfxPlayer.PlayOneShot(soundEffect);
    }

    public static void SetLooping(bool looping)
    {
        isLooping = looping;
    }

    public static string CurrentTrack()
    {
        return _titles[currentTrack];
    }

    public static void NextTrack()
    {
        if (currentTrack < _bgm.Length - 1)
        {
            currentTrack++;
        }
        else
        {
            currentTrack = 0;
        }
        PlayTrack();
    }

    public static void PrevTrack()
    {
        if (currentTrack > 0)
        {
            currentTrack--;
        }
        else
        {
            currentTrack = _bgm.Length - 1;
        }
        PlayTrack();
    }

    public static void FirstTrack()
    {
        currentTrack = 0;
        PlayTrack();
    }

    public static void LastTrack()
    {
        currentTrack = _bgm.Length - 1;
        PlayTrack();
    }

    public static void PlayTrack()
    {
        if(bgmPlayer .clip != null)
        {
            bgmPlayer.Stop();
            bgmPlayer.clip = _bgm[currentTrack];
            bgmPlayer.loop = isLooping;
            bgmPlayer.Play();
        }
    }

    public static bool IsMuted()
    {
        return sfxPlayer.mute;
    }

    public static void Mute()
    {
        bgmPlayer.mute = true;
        sfxPlayer.mute = true;
    }

    public static void UnMute()
    {
        bgmPlayer.mute = false;
        sfxPlayer.mute = false;
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("BGM", BGMVolume);
        PlayerPrefs.SetFloat("SFX", SFXVolume);
        PlayerPrefs.SetInt("Mute", Convert.BoolToInt(sfxPlayer.mute));
    }
}
