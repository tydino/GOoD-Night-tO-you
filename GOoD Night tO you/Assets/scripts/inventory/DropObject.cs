using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour {
    public HoldObject Holder;
    public KeyCode Dropkey;
    public KeyCode PutAwaykey;

    void Update(){
        if (Holder.canDrop){
            if(Input.GetKey(Dropkey) == true && Holder.ItemBeingHeld != null && Holder.itemBeingHeldDrop != null){
                Holder.dropOrStopHold(false);
            }
            if(Input.GetKey(PutAwaykey) == true && Holder.ItemBeingHeld != null && Holder.itemBeingHeldDrop != null){
                Holder.dropOrStopHold(true);
            }
        }
    }
}