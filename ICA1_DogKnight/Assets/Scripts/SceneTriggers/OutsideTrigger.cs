using UnityEngine;
using UnityEngine.SceneManagement;

public class OutsideTrigger : MonoBehaviour
{
    public GameObject blackScreen;

    public void OnTriggerEnter()
    {
        blackScreen.SetActive(true);
        SceneManager.LoadScene("OutsideScene");
    }
}
