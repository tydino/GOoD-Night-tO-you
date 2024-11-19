using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour {
    public InventoryItemData referenceItem;
    public KeyCode pressToCollect;
    public bool doesUseTrigger;

    public void OnHandlePickupItem() {
        InventorySystem.current.Add(referenceItem);
        Destroy(gameObject);
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