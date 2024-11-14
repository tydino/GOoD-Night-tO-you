using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    bool now = false;
    public Transform Target;

    void Update()
    {
        if(now){
            transform.LookAt(Target);
        }
    }
}
