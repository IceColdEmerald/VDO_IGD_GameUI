using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

[RequireComponent(typeof(AudioSource))]
public class MenuButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 startScale;

    [SerializeField] float scale = 1.1f;
 
    AudioSource audioSource => GetComponent<AudioSource>();
    [SerializeField] AudioClip hoverSound;

    void Start()
    {
        startScale = transform.localScale;
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.PlayOneShot(hoverSound);
        transform.DOScale(startScale * scale, 0.6f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(startScale, 0.6f);
    }

}
