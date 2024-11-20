using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Unity.Properties;

public class InventorySystem : MonoBehaviour //original by game dev guide; https://www.youtube.com/watch?v=SGz3sbZkfkg
{
    public UnityEvent onInventoryChangedEvent;
    Dictionary<InventoryItemData, InventoryItem> m_itemDictionary;
    public static InventorySystem current;
    public List<InventoryItem> ININVENTORY;
    public List<InventoryItem> inventory {get; private set;}

    void Awake(){
        current=this;
        inventory = new List<InventoryItem>();
        m_itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
    }

    void Update(){
        ININVENTORY = inventory;
    }

    public InventoryItem Get(InventoryItemData referenceData){
        if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value)){
            return value;
        }
        return null;
    }

    public void Add(InventoryItemData referenceData){
        if(m_itemDictionary.TryGetValue(referenceData, out InventoryItem value)){
            value.AddToStack();
        }else{
            InventoryItem newItem = new InventoryItem(referenceData);
            inventory.Add(newItem);
            m_itemDictionary.Add(referenceData, newItem);
        }
        onInventoryChangedEvent.Invoke();
    }

    public void Remove(InventoryItemData referenceData){
        if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value)){
            value.RemoveFromStack();

            if(value.stackSize == 0){
                inventory.Remove(value);
                m_itemDictionary.Remove(referenceData);
            }
        }
        onInventoryChangedEvent.Invoke();
    }
}

[System.Serializable]
public class InventoryItem{
    public InventoryItemData data;
    public int stackSize;

    public InventoryItem(InventoryItemData source){
        data = source;
        AddToStack();
    }
    public void AddToStack(){
        stackSize++;
    }
    public void RemoveFromStack(){
        stackSize--;
    }
}