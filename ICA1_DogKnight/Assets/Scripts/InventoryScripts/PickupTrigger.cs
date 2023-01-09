using PixelCrushers.DialogueSystem;
using UnityEngine;

public class PickupTrigger : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Specify the tag that triggers this behaviour")]
    private string activationTag;

    [SerializeField]
    private LayerMask activationLayer;

    public Item item;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == activationTag && activationLayer.OnLayer(other.gameObject) && other.gameObject.name.Contains("Player"))
        {
            Inventory.instance.Add(item);
            if (gameObject.name.Contains("Candle"))
            {
                bool hasWax = DialogueLua.GetVariable("HasWax").AsBool;
                hasWax = true;
                DialogueLua.SetVariable("HasWax", hasWax);
            }
            else if(gameObject.name.Contains("Flower"))
            {
                int flowers = DialogueLua.GetVariable("FlowersCollected").AsInt;
                flowers++;
                DialogueLua.SetVariable("FlowersCollected", flowers);
            }

            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("Item");
        }
    }
}
