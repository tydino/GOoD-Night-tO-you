using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockMouse : MonoBehaviour
{
    bool OnStart = false;
    bool now = false;
    // Start is called before the first frame update
    void Start()
    {
        if (OnStart == true){
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible=true;
        }
    }

    void Update() {
        if (now == true){
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible=true; 
        }
    }
}
