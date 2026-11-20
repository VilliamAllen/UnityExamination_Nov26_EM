using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenManager : MonoBehaviour
{
    public void GoHome() { SceneManager.LoadScene("MainMenu"); }
}