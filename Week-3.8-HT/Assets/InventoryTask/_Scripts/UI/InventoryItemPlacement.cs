using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemPlacement : MonoBehaviour
{
    public PlayerController playerCon;
    public GameObject WhereToShow;
    public GameObject InventoryController;
    public GameObject ItemFramePrefab;
    public List<GameObject> ItemFrame;
    public WearableFrameScript[] WearableFrames;
    public Sprite DefaultArmorSprite;
    public float width;
    public float minHeight;
    public int NumInRow;
    public int sizeOfImage;

    int CurNumberOfItems;

    void Start()
    {
        ReCreateFrames();
    }

    void Update()
    {
        if (CurNumberOfItems != playerCon.player.inventory.Items.Count)
            ReCreateFrames();
    }

    void ReCreateFrames()
    {
        foreach (GameObject go in ItemFrame)
            Destroy(go);
        ItemFrame = new List<GameObject>();
        float height = Mathf.Clamp((playerCon.player.inventory.Items.Count / (NumInRow) + 1) * (sizeOfImage + 20), minHeight, Mathf.Infinity);
        WhereToShow.GetComponent<RectTransform>().sizeDelta = new Vector2(width, height);

        Inventory invRef = playerCon.player.inventory;

        CurNumberOfItems = invRef.Items.Count;
        for (int i = 0; i < CurNumberOfItems; i++)
        {
            ItemFrame.Add(Instantiate(ItemFramePrefab));
            ItemFrame[i].GetComponent<ItemFrameScript>().InitButton(invRef.Items[i],width,height,i,NumInRow,sizeOfImage, InventoryController,WhereToShow);
        }

        for (int i =0;i<WearableFrames.Length;i++)
        {
            WearableFrames[i].InitButton(invRef.Wearable[i],i,InventoryController, DefaultArmorSprite);
        }
    }

    public void ItemActivatedFromInventory(Item item, int index)
    {
        if (playerCon.player.inventory.TryActivateItemFromInventory(item, index))
            ReCreateFrames();
    }
    public void ItemActivatedFromWearable(Item item, int index)
    {
        if (playerCon.player.inventory.TryActivateItemFromWearable(item, index))
            ReCreateFrames();
    }
}
