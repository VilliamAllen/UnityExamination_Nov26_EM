using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public int currentCoins = 0;
    public int totalCoins = 5;
    public TextMeshProUGUI coinText;
    public AudioSource coinAudioSource;
    public AudioResource coinPickupSound;

    void Awake() { instance = this; }
    void Start() { UpdateUI(); }

    public void AddCoin()
    {
        currentCoins++;
        UpdateUI();
        if (coinAudioSource != null && coinPickupSound != null)
        {
            coinAudioSource.resource = coinPickupSound;
            coinAudioSource.Play();
        }
    }

    void UpdateUI() { coinText.text = "Coins: " + currentCoins + " / " + totalCoins; }
    public bool HasAllCoins() { return currentCoins >= totalCoins; }
}