using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace InventoryMaster
{
    public class ItemAttributeList : ScriptableObject
    {
        [SerializeField]
        public List<ItemAttribute> itemAttributeList = new List<ItemAttribute>();

    }
}
