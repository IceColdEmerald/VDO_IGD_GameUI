using UnityEngine;

public class ClickAudio : MonoBehaviour
{
    public static ClickAudio Instance;

    AudioSource audioSource;

    void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
