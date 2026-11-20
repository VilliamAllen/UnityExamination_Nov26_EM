using UnityEngine;
using UnityEngine.EventSystems;

public class UIFeedback : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public AudioSource uiAudioSource;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverSound != null && uiAudioSource != null) uiAudioSource.PlayOneShot(hoverSound);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (clickSound != null && uiAudioSource != null) uiAudioSource.PlayOneShot(clickSound);
    }
}