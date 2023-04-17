using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    public delegate void OnSlotCountChange(int val); //대리자 정의
    public OnSlotCountChange onSlotCountChange; //대리자 인스턴스화

    private bool IsUseStorage;
    public bool isUseStorage
    {
        get => IsUseStorage;
        set
        {
            IsUseStorage = value;
        }
    }

    private int slotCnt; //slot 사이즈 정할 변수
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
