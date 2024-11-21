using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldObject : MonoBehaviour
{
    public Transform ObjectThatHolds;
    public static GameObject ItemBeingHeld;

    public static void ObjectToHold(GameObject obj) {
        Debug.Log("object being held "+obj.name);
    }
}
