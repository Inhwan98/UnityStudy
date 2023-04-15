using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCotroller : MonoBehaviour
{
    public static PlayerCotroller instance = null;

    //������
    public InventoryUI InvenUI;
    private Inventory inven;
    [HideInInspector]
    public int AmountCoin;
    [HideInInspector]
    public int ItemCnt;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);

        inven = GetComponent<Inventory>();
        InvenUI = GameObject.Find("Canvas").GetComponent<InventoryUI>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ITEM")
        {
            //Item Ŭ������ hitObject �ν��Ͻ�ȭ ����.
            //��� ������Ʈ�� ConsumableŬ������ item�� ȣ���Ѵ�.
            Item hitObject = other.gameObject.GetComponentInParent<Consum>().item;
            Debug.Log("item");

            //��ũ��Ʈ�� ���������� �ҷ����� ��
            if (hitObject != null)
            {
                /*print("Hit: " + hitObject.objectName);*/
                //shouldDisapper�� �ʱ�ȭ
                bool shouldDisapper = false;

                //switch���� ����Ͽ� Item ��ũ��Ʈ�� itemType enum ������ ����
                switch (hitObject.itemType)
                {
                    case Item.ItemType.WAEPON:
                        if (ItemCnt < inven.SlotCnt)
                        {
                            InvenUI.slots[ItemCnt++].UpdateSlotUI(hitObject);
                            shouldDisapper = true;
                        }
                        break;

                    default:
                        break;
                }

                //shouldDisapper�� true�϶� �±׵� ���ӿ�����Ʈ ��Ȱ��ȭ
                if (shouldDisapper)
                {
                    Destroy(other.gameObject);
                }
            }
        }
    }
}
