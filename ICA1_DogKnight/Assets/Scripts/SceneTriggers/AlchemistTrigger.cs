using UnityEngine;
using UnityEngine.SceneManagement;

public class AlchemistTrigger : MonoBehaviour
{
    public GameObject blackScreen;

    private void OnTriggerEnter()
    {
        blackScreen.SetActive(true);
        SceneManager.LoadScene("AlchemistScene");
    }
}
