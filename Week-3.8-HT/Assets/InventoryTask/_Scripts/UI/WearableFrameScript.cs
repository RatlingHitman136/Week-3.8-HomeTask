using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WearableFrameScript : MonoBehaviour
{
    Item item;
    int index;
    GameObject InventoryController;
    Sprite Default;
    public void InitButton(Item item,int index,GameObject InventoryController, Sprite Default)
    {
        this.Default = Default;
        this.item = item;
        this.index = index;
        this.InventoryController = InventoryController;
        if (item != null)
            this.transform.GetChild(0).GetComponent<Image>().sprite = item.graphic.sprite;
        else
            this.transform.GetChild(0).GetComponent<Image>().sprite = Default;

        this.transform.parent = InventoryController.transform;
    }
    public void Clicked()
    {
        InventoryController.GetComponent<InventoryItemPlacement>().ItemActivatedFromWearable(item, index);
    }

}
