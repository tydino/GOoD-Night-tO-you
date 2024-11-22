using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldObject : MonoBehaviour
{
    public Transform ObjectThatHolds;
    public GameObject ItemBeingHeld;
    public Animator animator;

    public void ObjectToHold(GameObject obj) {
        Destroy(ItemBeingHeld);
        animator.SetBool("hold", true);
        GameObject Objection = Instantiate(obj);
        Objection.transform.SetParent(ObjectThatHolds, false);
        ItemBeingHeld = Objection; 
    }
    public void dropOrStopHold(bool hold){
        animator.SetBool("hold", false);
        Destroy(ItemBeingHeld);
    }
}
