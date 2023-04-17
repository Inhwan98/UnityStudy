using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorageSlot : MonoBehaviour
{
    public Storage storage;
    Inventory inven;
    InventoryUI invenUI;
    PlayerCotroller player;


    public Image itemIcon;
    public Item item;

    private void Awake()
    {
        storage = GameObject.FindWithTag("Box").GetComponent<Storage>();
    }

    private void Start()
    {
        player = PlayerCotroller.instance;
        inven = Inventory.instance;
        invenUI = InventoryUI.instance;

    }

    public void UpdateSlotUI(Item _item)
    {
        item = _item;
        itemIcon.sprite = item.itemImage;
        itemIcon.gameObject.SetActive(true);
    }

    //���Թ�ư�� onclick�Լ��� �߰�
    //�κ��丮���� �������� Ÿ��Ȯ���ϰ� ����
    public void useSlot()
    {
        if (ClickMovement.instance.isShop)
        {
            switch (item.itemType)
            {

                case Item.ItemType.WAEPON:
                    Debug.Log($"Player{player.ItemCnt}");
                    Debug.Log($"storage{storage.ItemCnt}");
                    itemIcon.sprite = null;
                    itemIcon.gameObject.SetActive(false);
                    invenUI.slots[++player.ItemCnt].UpdateSlotUI(item);


                    storage.ItemCnt--;

                    item = null;
                    break;

                default:
                    Debug.Log("Empty");
                    break;
            }
        }
    }
}
