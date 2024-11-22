using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour {
    public HoldObject Holder;
    public KeyCode Dropkey;

    void Update(){
        if(Input.GetKey(Dropkey) && Holder.ItemBeingHeld != null && Holder.itemBeingHeldDrop != null){
            Holder.dropOrStopHold(false);
        }
    }
}