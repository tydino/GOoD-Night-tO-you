using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory Item Data")]
public class InventoryItemData : ScriptableObject //original by game dev guide; https://www.youtube.com/watch?v=SGz3sbZkfkg with editations to match what is needed for GOoD Night tO you!
{
    public string id;
    public string displayName;
    public Sprite icon;
    public GameObject prefab;
    public GameObject WhenHold;
    public InventoryItemType whereIsItSorted; 
}

public enum InventoryItemType {objects, plushies, collectables, weapons}
