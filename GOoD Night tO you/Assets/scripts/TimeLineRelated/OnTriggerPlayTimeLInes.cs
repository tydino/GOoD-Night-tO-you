using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class OnTriggerPlayTimeLInes : MonoBehaviour
{
    public PlayableDirector[] startThese;
    public PlayableDirector[] endThese;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i < startThese.Length; i++)
            {
                StopAndPlayTimeLines.current.StartTimeLine(startThese[i]);
            }
            for (int i = 0; i < endThese.Length; i++)
            {
                StopAndPlayTimeLines.current.StopTimeLine(endThese[i]);
            }
        }

    }
}
