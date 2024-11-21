using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject m_SlotPrefab;
    public int WhichObjects;
    void Update()
    {
        OnUpdateInventory();
    }

    void OnUpdateInventory(){
        foreach(Transform t in transform){
            Destroy(t.gameObject);
        }

        DrawInventory();
    }

    void DrawInventory(){
        foreach(InventoryItem item in InventorySystem.current.inventory){
            if (WhichObjects==0 && item.whereIsItSorted == objects){AddInventorySlot(item);}
            if (WhichObjects==1 && item.whereIsItSorted == plushies){AddInventorySlot(item);}
            if (WhichObjects==2 && item.whereIsItSorted == collectables){AddInventorySlot(item);}
        }
    }
    public void AddInventorySlot(InventoryItem item){
        GameObject obj = Instantiate(m_SlotPrefab);
        obj.transform.SetParent(transform, false);

        Slots slot = obj.GetComponent<Slots>();
        slot.Set(item);
    }
}