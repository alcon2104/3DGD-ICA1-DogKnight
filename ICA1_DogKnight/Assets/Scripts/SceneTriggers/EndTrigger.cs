using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameObject blackScreen;

    private void OnTriggerEnter()
    {
        blackScreen.SetActive(true);
        SceneManager.LoadScene("EndMenu");
    }
}