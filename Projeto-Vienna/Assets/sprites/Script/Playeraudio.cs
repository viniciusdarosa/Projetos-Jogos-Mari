using UnityEngine;

public class playeraudio : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip jumpsound;
    public AudioClip coinssound;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySFX(AudioClip sfx)
    {
        audioSource.PlayOneShot(sfx);
    }
}
