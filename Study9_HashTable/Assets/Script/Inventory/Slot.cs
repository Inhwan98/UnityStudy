using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private StorageUI storageui;
    private Storage storage;
    private PlayerCotroller player;
    private GameManager gmr;

    public Item item;
    public Image itemIcon;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerCotroller>();
        storageui = GameObject.FindWithTag("StorageUI").GetComponent<StorageUI>();
        storage = GameObject.Find("Storage").GetComponent<Storage>();
    }

    private void Start()
    {
        gmr = GameManager.instance;
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
                    itemIcon.sprite = null;
                    itemIcon.gameObject.SetActive(false);
                    storageui.slots[++storage.ItemCnt].UpdateSlotUI(item);
                    gmr.HashPut(item.name, item.waeponGrade);
                    player.ItemCnt -= 1;
                    item = null;
                    break;

                default:
                    Debug.Log("Empty");
                    break;
            }
            //안해주면 다음에 아이템을 못주움

        }
    }
}
