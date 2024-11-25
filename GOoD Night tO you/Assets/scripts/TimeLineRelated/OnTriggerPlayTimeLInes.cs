using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class OnTriggerPlayTimeLInes : MonoBehaviour
{
    public PlayableDirector[] startThese;
    public PlayableDirector[] endThese;    
    public BarrierClass Barrier;
    GameObject barrierClone;
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
            if (Barrier.usesBarrier == true)
            {
            barrierClone = Instantiate(Barrier.BarrierObject);
            barrierClone.transform.SetParent(Barrier.BarrierParent, false);
            barrierClone.transform.position = Barrier.barrierPlacement.position;
            }
        }

    }
    public void OneFinnishOfTimeLine()
    {
        Destroy(barrierClone);
    }
}
