using Assets.InventoryTask._Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct WeaponArgs
{
    public float meleeDamage;
    public float durability;

    public WeaponArgs(float meleeDamage,float durability)
    {
        this.meleeDamage = meleeDamage;
        this.durability = durability;
    }
}

[System.Serializable]
public class Weapon : Wearable
{
    float meleeDamage;
    float durability;

    public Weapon(WeaponArgs Wargs, ItemArgs Iargs) : base(Iargs)
    {
        this.meleeDamage = Wargs.meleeDamage;
        this.durability = Wargs.durability;
        typeOfWearable = TypeOfWearable.weapon;
    }

}
