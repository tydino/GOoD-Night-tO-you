using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StopAndPlayTimeLines : MonoBehaviour
{
    public static StopAndPlayTimeLines current;

    void Awake() {
        current = this;
    }

    public void StartTimeLine(PlayableDirector pd) {
        pd.Play();
    }

    public void StopTimeLine(PlayableDirector pd){
        pd.Stop();
    }
}
