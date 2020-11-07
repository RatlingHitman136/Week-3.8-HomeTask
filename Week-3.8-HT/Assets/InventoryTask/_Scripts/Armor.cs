using Assets.InventoryTask._Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct ArmorArgs
{
    public float meleeDamage;
    public float durability;
    public TypeOfWearable typeOfWearable;

    public ArmorArgs(float meleeDamage, float durability, TypeOfWearable typeOfWearable)
    {
        this.meleeDamage = meleeDamage;
        this.durability = durability;
        this.typeOfWearable = typeOfWearable;
    }
}

[System.Serializable]
public class Armor : Wearable
{
    float Defence;
    float durability;

    public Armor(ArmorArgs Aargs,ItemArgs Iargs) : base(Iargs)
    {
        this.Defence = Aargs.meleeDamage;
        this.durability = Aargs.durability;
        typeOfWearable = Aargs.typeOfWearable;
    }

}
