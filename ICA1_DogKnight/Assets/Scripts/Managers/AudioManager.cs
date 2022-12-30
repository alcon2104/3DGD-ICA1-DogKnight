using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

//Code found from Brackeys: 'START MENU in Unity' accessed December 21st 2022 (https://www.youtube.com/watch?v=6OT43pvUyfY&ab_channel=Brackeys)
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

       foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Play("Theme");
        if(SceneManager.GetActiveScene().name == "GroundsScene" || SceneManager.GetActiveScene().name == "OutsideScene")
        {
            Play("Background Noise");
        }
        if (SceneManager.GetActiveScene().name == "TavernScene" || SceneManager.GetActiveScene().name == "AlchemistScene")
        {
            Play("Fire");
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
