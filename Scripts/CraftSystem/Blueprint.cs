using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace InventoryMaster
{
    [System.Serializable]
public class Blueprint
{

    public List<int> ingredients = new List<int>();
    public List<int> amount = new List<int>();
    public Item finalItem;
    public int amountOfFinalItem;
    public float timeToCraft;
    public ItemCategory itemCategory;


    public Blueprint(List<int> ingredients, int amountOfFinalItem, List<int> amount, Item item)
    {
        this.ingredients = ingredients;
        this.amount = amount;
        finalItem = item;
    }

    public Blueprint() { }

}
}