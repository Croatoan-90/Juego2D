
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource bgAudioSource;
    public AudioSource soundsAudioSource;

    public AudioClip jump;
    public AudioClip coin;

    public Slider volumeSlider;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = bgAudioSource.volume;
    }

    public void ChangeVolume()
    {
        bgAudioSource.volume = volumeSlider.value;
    }

    public void PlayJump()
    {
        PlaySound(jump);
    }

    public void PlayCoin()
    {
        PlaySound(coin);
    }

    private void PlaySound(AudioClip clip)
    {
        soundsAudioSource.PlayOneShot(clip);
    }
}
