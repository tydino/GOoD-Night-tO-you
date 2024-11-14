using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class triggerChange : MonoBehaviour
{
    public string scene;

    public Collider player;

    void OnTriggerEnter(Collider other){
        if(other==player)
        {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
    }
}
