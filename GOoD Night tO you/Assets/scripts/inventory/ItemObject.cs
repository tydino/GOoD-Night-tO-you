using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour {
    public InventoryItemData referenceItem;
    public KeyCode pressToCollect;

    public List<ItemRequirement> requirements;

    public bool removeRequirementsOnPickup;
    public bool doesUseTrigger;

    public void OnHandlePickupItem() 
    {
        if(meetsRequirements()){
            if(removeRequirementsOnPickup){
                RemoveRequirements();
            }
            InventorySystem.current.Add(referenceItem);
            Destroy(gameObject);
        }
    }

    bool meetsRequirements(){
        foreach(ItemRequirement requirement in requirements){
            if(!requirement.hasRequirement()){
                return false;
            }else{
                return true;
            }
        }
        return true;
    }

    void RemoveRequirements(){
        foreach(ItemRequirement requirement in requirements){
            for(int i = 0; i < requirement.amount; i++){
                InventorySystem.current.Remove(requirement.itemData);
            }
        }
    }

    void OnTriggerStay(Collider other){//this is my edit, it just allows for more control on my part.
        if (other.gameObject.tag == "Player"){
            if (Input.GetKey(pressToCollect)){
                if(doesUseTrigger){
                    OnHandlePickupItem();
                }
            }
        }
    }
}

[System.Serializable]
public struct ItemRequirement{
    public InventoryItemData itemData;
    public int amount;

    public bool hasRequirement(){
        InventoryItem item = InventorySystem.current.Get(itemData);

        if(item == null || item.stackSize < amount){
            return false;
        }
        return true;
    }
}