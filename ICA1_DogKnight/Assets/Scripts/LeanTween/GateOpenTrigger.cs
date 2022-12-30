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

    private void OnTriggerEnter()
    {
        DialogueManager.StartConversation("Gate Event", actor.transform, conversant.transform);
    }
}
