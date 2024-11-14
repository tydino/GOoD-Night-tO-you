using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class buttonChange : MonoBehaviour
{
    public string scene;

    public void change(){
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
