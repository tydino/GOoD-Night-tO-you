using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionToShowUI : MonoBehaviour
{
    public KeyCode keycode;
    public GameObject ThingToShow;
    public GameObject thingToHide;

    public void Start(){
        ThingToShow.SetActive(false);
    }
    void Update() 
    {
        if(Input.GetKey(keycode)){
            ThingToShow.SetActive(true);
            thingToHide.SetActive(false);
        }
    }
}
