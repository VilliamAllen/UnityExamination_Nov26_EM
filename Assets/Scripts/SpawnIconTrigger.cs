using UnityEngine;

public class SpawnIconTrigger : MonoBehaviour
{
    public GameObject iconCanvas;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && iconCanvas != null)
        {
            iconCanvas.SetActive(true);
        }
    }
}