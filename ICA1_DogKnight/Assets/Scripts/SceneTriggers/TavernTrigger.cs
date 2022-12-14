using UnityEngine;
using UnityEngine.SceneManagement;

public class TavernTrigger : MonoBehaviour
{
    public GameObject blackScreen;

    private void OnTriggerEnter()
    {
        blackScreen.SetActive(true);
        SceneManager.LoadScene("TavernScene");
    }
}
