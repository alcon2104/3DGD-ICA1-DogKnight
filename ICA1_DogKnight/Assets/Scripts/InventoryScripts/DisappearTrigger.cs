using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearTrigger : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Specify the tag that triggers this behaviour")]
    private string activationTag;

    [SerializeField]
    private LayerMask activationLayer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == activationTag && activationLayer.OnLayer(other.gameObject) && other.gameObject.name == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
