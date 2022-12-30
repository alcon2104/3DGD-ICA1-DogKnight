using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

//Code found from Brackeys: 'PAUSE MENU in Unity' accessed October 30th 2022 (https://www.youtube.com/watch?v=JivuXdrIHK0&ab_channel=Brackeys)
public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;
    public GameObject pauseMenuUI;

    [SerializeField]
    private GameObject menuCamera;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        menuCamera.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        menuCamera.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
