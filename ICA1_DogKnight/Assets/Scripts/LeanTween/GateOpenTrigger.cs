using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class GateOpenTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject actor;

    [SerializeField]
    private GameObject conversant;

    [SerializeField]
    private GameObject outsideTrigger;

    private void OnTriggerEnter()
    {
        DialogueManager.StartConversation("Gate Event", actor.transform, conversant.transform);
    }

    public void OpenGate()
    {
        LeanTween.moveY(conversant, 6f, 1f);
        FindObjectOfType<AudioManager>().Play("Gate Opening");
        outsideTrigger.SetActive(true);
    }
}
