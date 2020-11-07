using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct ItemArgs
{
    public string Name;
    public int cost;
    public int weight;
    public Graphics graphic;

    public ItemArgs(string Name, int cost, int weight,Graphics graphic)
    {
        this.Name = Name;
        this.cost = cost;
        this.graphic = graphic;
        this.weight = weight;
    }
}

[System.Serializable]
public class Item
{
    public string Name;
    public int cost;
    public int weight;
    public Graphics graphic;

    public Item(ItemArgs args)
    {
        this.Name = args.Name;
        this.cost = args.cost;
        this.graphic = args.graphic;
        this.weight = args.weight;
    }
}
