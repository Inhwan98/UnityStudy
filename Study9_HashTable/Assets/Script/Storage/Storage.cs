using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    public delegate void OnSlotCountChange(int val); //�븮�� ����
    public OnSlotCountChange onSlotCountChange; //�븮�� �ν��Ͻ�ȭ

    private bool IsUseStorage;
    public bool isUseStorage
    {
        get => IsUseStorage;
        set
        {
            IsUseStorage = value;
        }
    }

    private int slotCnt; //slot ������ ���� ����
    public int SlotCnt
    {
        get => slotCnt;
        set
        {
            slotCnt = value;
            onSlotCountChange.Invoke(slotCnt);
        }
    }

    private int itemCnt;
    public int ItemCnt
    {
        get => itemCnt;
        set
        {
            itemCnt = value;
        }
    }

    void Start()
    {
        SlotCnt = 4;
        itemCnt = -1;
    }
}
