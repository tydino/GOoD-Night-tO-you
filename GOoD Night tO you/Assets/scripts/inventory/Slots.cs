using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    HoldObject ho;
    [SerializeField]
    public Image m_icon;

    [SerializeField]
    public Text m_label;

    [SerializeField]
    public GameObject m_stackObj;

    [SerializeField]
    public GameObject m_objectPrefab;

    [SerializeField]
    public GameObject m_holdPrefab;
    InventoryItemData iid;

    [SerializeField]
    public Text m_stackLabel;
    public void SetAsHold(){
        ho.ObjectToHold(m_holdPrefab, m_objectPrefab, iid);
    }
    public void Set(InventoryItem item){
        ho=GameObject.FindWithTag("player").GetComponent<HoldObject>();
        if(item.data.icon != null){
            m_icon.sprite = item.data.icon;
        }
        m_label.text = item.data.displayName;
        m_objectPrefab = item.data.prefab;
        m_holdPrefab = item.data.WhenHold;
        iid=item.data;
        if(item.stackSize <=1){
            m_stackObj.SetActive(false);
            return;
        }

        m_stackLabel.text = item.stackSize.ToString();
    }
}
