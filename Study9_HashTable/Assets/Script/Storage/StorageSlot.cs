using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StorageSlot : MonoBehaviour
{
    public Storage storage;
    Inventory inven;
    InventoryUI invenUI;
    PlayerCotroller player;


    public Image itemIcon;
    public Item item;

    // ���ھ� �ؽ�Ʈ�� ������ ����
    public TMP_Text gradeText;

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

    //���Թ�ư�� onclick�Լ��� �߰�
    //�κ��丮���� �������� Ÿ��Ȯ���ϰ� ����
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
