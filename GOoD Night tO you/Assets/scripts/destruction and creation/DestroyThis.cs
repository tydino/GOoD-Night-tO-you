using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour
{
    public GameObject This;
    public GameObject[] These;

    void DestroyNow()
    {
        Destroy(This);
        for(int i = 0;i<These.Length;i++){
            Destroy(These[i]);
        }
    }
}
