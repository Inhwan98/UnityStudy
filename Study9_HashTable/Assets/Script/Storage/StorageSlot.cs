using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorageSlot : MonoBehaviour
{
    Inventory inven;
    InventoryUI invenUI;
    PlayerCotroller player;

    public Image itemIcon;
    public Item item;

    private void Awake()
    {
        player = PlayerCotroller.instance;
        inven = Inventory.instance;
        invenUI = InventoryUI.instance;
    }

    private void Start()
    {

    }

    public void UpdateSlotUI(Item _item)
    {
        item = _item;
        itemIcon.sprite = item.itemImage;
        itemIcon.gameObject.SetActive(true);
    }

    //슬롯버튼에 onclick함수로 추가
    //인벤토리에서 눌렀을때 타입확인하고 진행
    public void useSlot()
    {
        if (ClickMovement.instance.isShop)
        {
            switch (item.itemType)
            {
                case Item.ItemType.WAEPON:
                    player.AmountCoin += item.quantity;
                    itemIcon.sprite = null;
                    itemIcon.gameObject.SetActive(false);

                    invenUI.slots[player.ItemCnt++].UpdateSlotUI(item);
                    item = null;
                    break;

                default:
                    Debug.Log("Empty");
                    break;
            }

        }
    }
}
