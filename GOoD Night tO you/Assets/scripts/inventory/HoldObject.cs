using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldObject : MonoBehaviour
{
    public bool canHold = true;
    public bool canDrop = false;
    public static HoldObject current;
    bool holdingObject;
    public InventorySystem IS;
    public GameObject ObjectThatHolds;
    InventoryItemData m_Iid;
    public GameObject ItemBeingHeld;
    public GameObject itemBeingHeldDrop;
    public Animator animator;
    
    void Start(){
        current = this;
    }

    public void ObjectToHold(GameObject obj, GameObject Drop, InventoryItemData iid) {
        if (canHold == true){
            canHold = false;
            canDrop = true;
            holdingObject=true;
            Destroy(ItemBeingHeld);
            animator.SetBool("hold", true);
            GameObject Objection = Instantiate(obj);
            Objection.transform.SetParent(ObjectThatHolds.transform, false);
            ItemBeingHeld = Objection; 
            itemBeingHeldDrop = Drop;
            m_Iid = iid;
        }
    }
    public void dropOrStopHold(bool hold){
        if (holdingObject && itemBeingHeldDrop != null && canDrop == true){
            canHold = true;
            canDrop = false;
            holdingObject=false;
            animator.SetBool("hold", false);
            Destroy(ItemBeingHeld);
            if (!hold && itemBeingHeldDrop != null){
                GameObject obj = Instantiate(itemBeingHeldDrop);
                obj.gameObject.transform.position = ObjectThatHolds.gameObject.transform.position;
                IS.Remove(m_Iid);
                itemBeingHeldDrop = null;
            }
        }
    }
}
