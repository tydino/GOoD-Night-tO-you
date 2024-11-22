using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldObject : MonoBehaviour
{
    bool holdingObject;
    public InventorySystem IS;
    public GameObject ObjectThatHolds;
    InventoryItemData m_Iid;
    public GameObject ItemBeingHeld;
    public GameObject itemBeingHeldDrop;
    public Animator animator;

    public void ObjectToHold(GameObject obj, GameObject Drop, InventoryItemData iid) {
        holdingObject=true;
        Destroy(ItemBeingHeld);
        animator.SetBool("hold", true);
        GameObject Objection = Instantiate(obj);
        Objection.transform.SetParent(ObjectThatHolds.transform, false);
        ItemBeingHeld = Objection; 
        itemBeingHeldDrop = Drop;
        m_Iid = iid;
    }
    public void dropOrStopHold(bool hold, GameObject ItemBeingDropped){
        if (holdingObject){
            holdingObject=false;
            animator.SetBool("hold", false);
            Destroy(ItemBeingHeld);
            if (!hold && ItemBeingDropped != null){
                GameObject obj = Instantiate(ItemBeingDropped);
                obj.gameObject.transform.position = ObjectThatHolds.gameObject.transform.position;
                IS.Remove(m_Iid);
            }
        }
    }
}
