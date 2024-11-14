using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePlayerCam : MonoBehaviour
{  
    public GameObject cam;
    PlayerCam pc;

    void Start(){
        pc = cam.GetComponent<PlayerCam>();
    }
    public void updateVoid(float amount)
    {
        float sx = PlayerCam.BaseSensX * amount;
        float sy = PlayerCam.BaseSensY * amount;
        pc.sensX = sx;
        pc.sensY = sy;
    }
}
