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
            Destroy(gameObject);
        }
    }
}
