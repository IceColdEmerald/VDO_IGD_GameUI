using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

[RequireComponent(typeof(AudioSource))]
public class StartButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    Vector3 startPosition;

    [SerializeField] float offset = 25f;

    AudioSource audioSource => GetComponent<AudioSource>();
    [SerializeField] AudioClip hoverSound;
    [SerializeField] AudioClip clickSound;

    void Start()
    {
        startPosition = transform.position;
        transform.position = startPosition;
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.PlayOneShot(hoverSound);
        transform.DOMoveX(startPosition.x + offset, 0.8f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOMoveX(startPosition.x, 0.8f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ClickAudio.Instance.PlaySound(clickSound);
    }
}
