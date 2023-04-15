using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCotroller : MonoBehaviour
{
    public static PlayerCotroller instance = null;

    //아이템
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
            //Item 클래스의 hitObject 인스턴스화 과정.
            //상대 오브젝트가 Consumable클래스의 item을 호출한다.
            Item hitObject = other.gameObject.GetComponentInParent<Consum>().item;
            Debug.Log("item");

            //스크립트를 성공적으로 불러왔을 때
            if (hitObject != null)
            {
                /*print("Hit: " + hitObject.objectName);*/
                //shouldDisapper값 초기화
                bool shouldDisapper = false;

                //switch문을 사용하여 Item 스크립트에 itemType enum 데이터 참조
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

                //shouldDisapper가 true일때 태그된 게임오브젝트 비활성화
                if (shouldDisapper)
                {
                    Destroy(other.gameObject);
                }
            }
        }
    }
}
