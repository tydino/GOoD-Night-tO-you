using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ObjectPlaysTimeLines : MonoBehaviour
{
    public BarrierClass barrier;
    GameObject barrierClone;
    public PlayableDirector[] startThese;
    public PlayableDirector[] endThese;
    public InventoryItemData dataToCompare;
    public string tagToLookFor;
    void OnTriggerEnter(Collider Object)
    {
        InventoryItemData data;
        if (Object.gameObject.tag == tagToLookFor)
        {
            data = Object.gameObject.GetComponent<ItemObject>().referenceItem;
            if(data==dataToCompare)
            {
                for (int i = 0; i < startThese.Length; i++)
                {
                    StopAndPlayTimeLines.current.StartTimeLine(startThese[i]);
                }
                for (int i = 0; i < endThese.Length; i++)
                {
                    StopAndPlayTimeLines.current.StopTimeLine(endThese[i]);
                }
                if (barrier.usesBarrier == true)
                {
                    barrierClone = Instantiate(barrier.BarrierObject);
                    barrierClone.transform.SetParent(barrier.BarrierParent, false);
                    barrierClone.transform.position = barrier.barrierPlacement.position;
                }
            }
        }

    }
}
[System.Serializable]
public class BarrierClass
{
    public Transform barrierPlacement;
    public GameObject BarrierObject;
    public Transform BarrierParent;
    public bool usesBarrier;
}
