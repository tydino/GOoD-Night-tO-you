using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    [SerializeField]
    public Image m_icon;

    [SerializeField]
    public Text m_label;

    [SerializeField]
    public GameObject m_stackObj;

    [SerializeField]
    public Text m_stackLabel;

    public void Set(InventoryItem item){
        m_icon.sprite = item.data.icon;
        m_label.text = item.data.displayName;
        if(item.stackSize <=1){
            m_stackObj.SetActive(false);
            return;
        }

        m_stackLabel.text = item.stackSize.ToString();
    }
}
