using UnityEngine.Audio;
using UnityEngine;

//Code found from Brackeys: 'START MENU in Unity' accessed December 21st 2022 (https://www.youtube.com/watch?v=6OT43pvUyfY&ab_channel=Brackeys)
[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    [Range(0f, 2f)]
    public float volume;
    [Range(0.1f, 1.0f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
