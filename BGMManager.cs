using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public AudioSource bgmSource;

    public void PlayBGM(string musicFile)
    {
        AudioClip bgm = Resources.Load<AudioClip>("Audio/" + musicFile);
        if (bgm != null)
        {
            bgmSource.clip = bgm;
            bgmSource.Play();
        }
        else
        {
            Debug.LogError("BGM file not found: " + musicFile);
        }
    }
}
