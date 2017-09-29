using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Collections.Generic;

public class CreateCategoryDatabase : MonoBehaviour
{

    public static ItemCategoryList asset;                                                  //The List of all Items

#if UNITY_EDITOR
    public static ItemCategoryList createItemCategoryDatabase()                                    //creates a new ItemDatabase(new instance)
    {
        asset = ScriptableObject.CreateInstance<ItemCategoryList>();                       //of the ScriptableObject InventoryItemList

        AssetDatabase.CreateAsset(asset, "Assets/InventoryMaster/Resources/CategoryDatabase.asset");            //in the Folder Assets/Resources/ItemDatabase.asset
        AssetDatabase.SaveAssets();                                                         //and than saves it there        
        return asset;
    }
#endif

}