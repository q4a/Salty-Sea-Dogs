using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemCategoryList : ScriptableObject
{
    [SerializeField]
    public List<ItemCategory> itemCategoryList = new List<ItemCategory>();

}