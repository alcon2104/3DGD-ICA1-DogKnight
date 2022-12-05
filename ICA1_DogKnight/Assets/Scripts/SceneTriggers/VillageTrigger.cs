using UnityEngine;
using UnityEngine.SceneManagement;

public class VillageTrigger : MonoBehaviour
{
    public GameObject blackScreen;

    private void OnTriggerEnter()
    {
        blackScreen.SetActive(true);
        SceneManager.LoadScene("VillageScene");
    }
}