using Assets.InventoryTask._Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class Inventory
{
    public List<Item> Items;
    public int MaxItems;
    public int MaxWeight;
    public int CurrentWeight;

    public Item[] Wearable;

    public Inventory(int maxWieght, int maxItems)
    {
        Wearable = new Item[5];
        MaxWeight = maxWieght;
        MaxItems = maxItems;
        CurrentWeight = 0;
        Items = new List<Item>();
    }

    public bool TryAddItem(Item item)
    {
        if (MaxWeight < CurrentWeight + item.weight || Items.Count + 1 > MaxItems)
            return false;
        Items.Add(item);
        CurrentWeight += item.weight;
        return true;
    }
    public bool TryDeleteItem(int item_index)
    {
        Items.RemoveAt(item_index);
        return true;
    }

    public bool CanChangeItem(Item toInv,Item FromInv)
    {
        if (MaxWeight < CurrentWeight + toInv.weight - FromInv.weight)
            return false;

        return true;
    }


    public bool TryActivateItemFromInventory(Item item, int index)
    {
        if (item is Wearable)
        {
            switch ((item as Wearable).typeOfWearable)
            {
                case TypeOfWearable.weapon:
                    return TryReplaceItemFromInventoryToWearable(0, item, index);
                case TypeOfWearable.helmet:
                    return TryReplaceItemFromInventoryToWearable(1, item, index);
                case TypeOfWearable.chestplate:
                    return TryReplaceItemFromInventoryToWearable(2, item, index);
                case TypeOfWearable.leggins:
                    return TryReplaceItemFromInventoryToWearable(3, item, index);
                case TypeOfWearable.boots:
                    return TryReplaceItemFromInventoryToWearable(4, item, index);
            }

        }
        return false;
    }

    bool TryReplaceItemFromInventoryToWearable(int indexAtWearable, Item itemAtInventory,int index)
    {
        if (Wearable[indexAtWearable] == null)
        {
            TryDeleteItem(index);
            Wearable[indexAtWearable] = itemAtInventory;
            Debug.Log("nothing");
            return true;
        }
        if (CanChangeItem(Wearable[indexAtWearable], itemAtInventory))
        {
            TryDeleteItem(index);
            TryAddItem(Wearable[indexAtWearable]);
            Wearable[indexAtWearable] = itemAtInventory;
            return true;
        }
        return false;
    }

    public bool TryActivateItemFromWearable(Item item, int index)
    {
        if (TryAddItem(item))
            Wearable[index] = null;
        else
            return false;
        return true;
    }

}
