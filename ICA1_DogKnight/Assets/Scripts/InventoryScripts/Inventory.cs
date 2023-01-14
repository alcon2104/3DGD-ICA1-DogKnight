using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code found from Brackeys, 'ITEMS - Making an RPG in Unity (E04)' - accessed on January 9th, 2023, (https://www.youtube.com/watch?v=HQNl3Ff2Lpo&t=715s&ab_channel=Brackeys)
public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;

    void Awake ()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of inventory found!");
            return;
        }
        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public List<Item> items = new List<Item> ();

    public void Add (Item item)
    {
        items.Add(item);

        if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
