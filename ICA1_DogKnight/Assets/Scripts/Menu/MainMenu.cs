using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Code found from Brackeys: 'START MENU in Unity' accessed October 30th 2022 (https://www.youtube.com/watch?v=zc8ac_qUXQY&ab_channel=Brackeys)
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
