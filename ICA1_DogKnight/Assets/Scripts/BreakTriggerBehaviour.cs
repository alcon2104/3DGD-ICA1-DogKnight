using GD.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakTriggerBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToBreak;

    [SerializeField]
    [Tooltip("Specify the tag that triggers this fade")]
    private string activationTag;

    [SerializeField]
    private LayerMask activationLayer;

    private BreakObjectBehaviour breakObjectBehaviour;
    
    private void Awake()
    {
        breakObjectBehaviour = objectToBreak.GetComponent<BreakObjectBehaviour>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == activationTag && activationLayer.OnLayer(other.gameObject))
            breakObjectBehaviour.Break();
    }
}
