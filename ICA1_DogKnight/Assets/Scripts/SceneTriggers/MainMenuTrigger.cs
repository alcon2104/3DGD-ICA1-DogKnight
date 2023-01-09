using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuTrigger : MonoBehaviour
{
    public GameObject blackScreen;

    private void OnTriggerEnter()
    {
        blackScreen.SetActive(true);
        SceneManager.LoadScene("MainMenu");
    }
}