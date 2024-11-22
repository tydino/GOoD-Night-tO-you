using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockMouse : MonoBehaviour
{
    public bool onStart;
    public bool onUpdate;
    public bool onStartLock;
    public bool now;
    void Start(){
        if (onStart)
        if(onStartLock){
            Cursor.lockState = CursorLockMode.Locked;
            Settings.current.playercam.canMove = true;
        }else{
            Cursor.lockState = CursorLockMode.None;
            Settings.current.playercam.canMove = false;
        }
    }

    void Update(){
        if (onUpdate)
        if(now){
            Cursor.lockState = CursorLockMode.Locked;
            Settings.current.playercam.canMove = true;
        }else{
            Cursor.lockState = CursorLockMode.None;
             Settings.current.playercam.canMove = false;
        }
    }
}
