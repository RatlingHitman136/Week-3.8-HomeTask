using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemFrameScript : MonoBehaviour
{
    public Item ItemInsideFrame;
    public int index;
    public GameObject InventoryController;
    public void InitButton(Item item, float width, float height, int index, int NumInRow, int sizeOfImage, GameObject InventoryController, GameObject WhereToShow)
    {
        ItemInsideFrame = item;
        this.index = index;
        this.InventoryController = InventoryController;
        this.transform.GetChild(0).GetComponent<Image>().sprite = ItemInsideFrame.graphic.sprite;
        this.transform.parent = WhereToShow.transform;
        this.transform.localPosition = new Vector3(-width / 2 + (index % NumInRow) * (sizeOfImage + 20), (height / 2 - 50) - (index / NumInRow) * (sizeOfImage + 20), 0);
    }

    public void Clicked()
    {
        InventoryController.GetComponent<InventoryItemPlacement>().ItemActivatedFromInventory(ItemInsideFrame,index);
    }

}
