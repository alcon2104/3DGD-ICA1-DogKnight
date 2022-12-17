using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundsTrigger : MonoBehaviour
{
    public GameObject blackScreen;

    private void OnTriggerEnter()
    {
        blackScreen.SetActive(true);
        SceneManager.LoadScene("GroundsScene");
    }
}