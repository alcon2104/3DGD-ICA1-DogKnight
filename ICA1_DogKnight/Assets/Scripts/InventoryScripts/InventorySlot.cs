using UnityEditor.UIElements;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;

//Code found from Brackeys, 'INVENTORY CODE - Making an RPG in Unity (E06)' - accessed on January 9th, 2023 (https://www.youtube.com/watch?v=YLhj7SfaxSE&ab_channel=Brackeys)

public class InventorySlot : MonoBehaviour
{
    public Image icon;

    Item item;

    public void AddItem (Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void ClearSlot ()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
    }
}
