using UnityEngine;
using System.Collections;

[System.Serializable]
public class ItemCategory
{

    public string categoryName;
    public ItemCategory(string _categoryName)
    {
        this.categoryName = _categoryName;
    }

    public ItemCategory() { }

}
