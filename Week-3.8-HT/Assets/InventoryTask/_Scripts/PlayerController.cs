using Assets.InventoryTask._Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player player;

    public Sprite SomeSpriteItem1;
    public Sprite SomeSpriteItem2;
    public Sprite SomeSpriteWeapon;
    public Sprite SomeSpriteArmorChestplate;

    int maxWeight = int.MaxValue;
    int InvSize = int.MaxValue;

    void Awake()
    {
        player = new Player(maxWeight, InvSize);


        Item item1 = new Item(new ItemArgs("1", 1, 1, new Graphics(SomeSpriteItem1)));
        Item item2 = new Item(new ItemArgs("1", 1, 1, new Graphics(SomeSpriteItem2)));
        Weapon sword = new Weapon(new WeaponArgs(1000f, Mathf.Infinity), new ItemArgs("1", 1, 1, new Graphics(SomeSpriteWeapon)));
        Armor chestplate = new Armor(new ArmorArgs(1000f, Mathf.Infinity,TypeOfWearable.chestplate), new ItemArgs("1", 1, 1, new Graphics(SomeSpriteArmorChestplate)));

        #region adding lots of items
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item2));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(item1));
        //Debug.Log(player.inventory.TryAddItem(sword));
        #endregion

        #region adding items
        player.inventory.TryAddItem(sword);
        player.inventory.TryAddItem(item2);
        player.inventory.TryAddItem(item2);
        player.inventory.TryAddItem(sword);
        player.inventory.TryAddItem(item1);
        player.inventory.TryAddItem(item1);
        player.inventory.TryAddItem(chestplate);
        #endregion
    }

}

[System.Serializable]
public class Player
{
    public Inventory inventory;

    public Player(int maxWeight, int InvSize)
    {
        inventory = new Inventory(maxWeight,InvSize);
    }

}