using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StorageUI : MonoBehaviour
{
    private Storage storage;

    public GameObject storagePanel;
    public StorageSlot[] slots;
    public Transform slotHolder;


    private void Awake()
    {
        storage = GameObject.Find("Storage").GetComponent<Storage>();
    }

    private void Start()
    {
        slots = slotHolder.GetComponentsInChildren<StorageSlot>();
        storage.onSlotCountChange += SlotChange;
        storagePanel.SetActive(false);
    }

    private void SlotChange(int val)
    {
        //SlotCnt��ŭ�� intractable�� true���ش�.
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < storage.SlotCnt)
                slots[i].GetComponent<Button>().interactable = true;
            else
                slots[i].GetComponent<Button>().interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (ClickMovement.instance.isShop == true)
        {
            storagePanel.SetActive(true);
        }
        else
        {
            storagePanel.SetActive(false);
        }
    }

    //SlotCnt�� ���� �����ش�.
    public void AddSlot()
    {
        storage.SlotCnt++;
    }
}
