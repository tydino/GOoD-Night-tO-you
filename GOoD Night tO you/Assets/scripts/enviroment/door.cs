using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public List<ItemRequirement> usesItem;
    public Animator anim;
    public KeyCode doorKey;
    public bool open;
    public bool InRange;
    public bool usesItems;
    bool HasMetRequirement = false;
    bool meetsRequirements(){
        foreach(ItemRequirement requirement in usesItem){
            if(!requirement.hasRequirement()){
                return false;
            }else{
                return true;
            }
        }
        return true;
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            InRange = true;
        }
    }
    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Player"){
            InRange = false;
        }
    }

    void Update()
    {
        if (Input.GetKey(doorKey) == true && usesItems == false && open == false && InRange == true){
            open = true;
        }else if (Input.GetKey(doorKey) == true && meetsRequirements() && open == false && InRange == true){
            open = true;
            HasMetRequirement = true;
        }else if (Input.GetKey(doorKey) == true && HasMetRequirement == true && open == false && InRange == true){
            open = true;
        }else if (Input.GetKey(doorKey) == true && open == true && InRange == true){
            open = false;
        }
        anim.SetBool("open", open);
    }
}

