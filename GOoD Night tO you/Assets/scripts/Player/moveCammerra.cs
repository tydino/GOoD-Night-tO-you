using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCammerra : MonoBehaviour
{
    public Transform cameraPosition;

    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
