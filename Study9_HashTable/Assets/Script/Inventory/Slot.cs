using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slot : MonoBehaviour
{
    private StorageUI storageui;
    private Storage storage;
    private PlayerCotroller player;
    private GameManager gmr;

    public Item item;
    public Image itemIcon;

    // 스코어 텍스트를 연결할 변수
    public TMP_Text gradeText;

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

        switch (_item.waeponGrade)
        {
            case Item.WaeponGrade.A:
                gradeText.color = Color.red;
                break;
            case Item.WaeponGrade.B:
                gradeText.color = Color.blue;
                break;
            case Item.WaeponGrade.C:
                gradeText.color = Color.yellow;
                break;
            case Item.WaeponGrade.D:
                gradeText.color = Color.white;
                break;
        }

        gradeText.text = $"{_item.waeponGrade}";
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
                    gradeText.text = $"";
                    storageui.slots[++storage.ItemCnt].UpdateSlotUI(item);
                    Debug.Log($"{item.name}");
                    gmr.HashPut(item.name, item.waeponGrade);
                    player.ItemCnt -= 1;
                    item = null;
                    break;

                default:
                    Debug.Log("Empty");
                    break;
            }

        }
    }
}
