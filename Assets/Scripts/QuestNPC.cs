using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuestNPC : MonoBehaviour
{
    public GameObject dialogPanel;
    public TextMeshProUGUI dialogText;
    public GameObject choiceButtonsContainer;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogPanel.SetActive(true);
            if (CoinManager.instance.HasAllCoins())
            {
                dialogText.text = "You collected all the coins! Choose which world you want to visit:";
                choiceButtonsContainer.SetActive(true);
            }
            else
            {
                dialogText.text = "Collect all the coins in the area before you can choose a world!";
                choiceButtonsContainer.SetActive(false);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) dialogPanel.SetActive(false);
    }

    public void LoadHappyWorld() { SceneManager.LoadScene("Level2_HappyWorld"); }
    public void LoadAnguishWorld() { SceneManager.LoadScene("Level3_WorldOfAnguish"); }
}