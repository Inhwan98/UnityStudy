using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{
    public enum ItemType
    {
        WAEPON
    }

    public enum WaeponType
    {
        GRENADE,
        GREENGUN,
        BLUEGUN,
        HAMMER,
    }

    public Sprite itemImage;
    public int quantity; //������ ����
    public bool stackable; // ����...true�� �ѹ��� ó���� �� ����... (�������� ������)

    public ItemType itemType;
    public WaeponType waeponType;
}

