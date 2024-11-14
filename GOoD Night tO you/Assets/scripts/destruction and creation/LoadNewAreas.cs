using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewAreas : MonoBehaviour
{
    public GameObject[] previousAreas;
    public GameObject[] whatIsBeingLoaded;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i < previousAreas.Length; i++)
            {
                if (previousAreas[i].activeInHierarchy == true && previousAreas[i] != null)
                {
                    previousAreas[i].SetActive(false);
                }
            }
            for (int i = 0; i < whatIsBeingLoaded.Length; i++)
            {
                if (whatIsBeingLoaded[i].activeInHierarchy == false && whatIsBeingLoaded[i] != null)
                {
                    whatIsBeingLoaded[i].SetActive(true);
                }
            }
        }
    }
}
