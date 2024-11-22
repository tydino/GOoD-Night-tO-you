using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public HoldObject ho;
    public GameObject m_SlotPrefab;
    public int WhichObjects;

    public void SwitchObject(int objectId){
        WhichObjects=objectId;
    }
    public void putAway(){
        ho.dropOrStopHold(true);
    }
    public void DropItem(){
        ho.dropOrStopHold(false);
        OnUpdateInventory();
    }

    public void OnUpdateInventory(){
        foreach(Transform t in transform){
            Destroy(t.gameObject);
        }

        DrawInventory();
    }

    void DrawInventory(){
        foreach(InventoryItem item in InventorySystem.current.inventory){
            if (WhichObjects==0 && item.data.whereIsItSorted == InventoryItemType.objects){AddInventorySlot(item);}
            if (WhichObjects==1 && item.data.whereIsItSorted == InventoryItemType.plushies){AddInventorySlot(item);}
            if (WhichObjects==2 && item.data.whereIsItSorted == InventoryItemType.collectables){AddInventorySlot(item);}
            if (WhichObjects==3 && item.data.whereIsItSorted == InventoryItemType.weapons){AddInventorySlot(item);}
        }
    }
    public void AddInventorySlot(InventoryItem item){
        GameObject obj = Instantiate(m_SlotPrefab);
        obj.transform.SetParent(transform, false);

        Slots slot = obj.GetComponent<Slots>();
        slot.Set(item);
    }
}