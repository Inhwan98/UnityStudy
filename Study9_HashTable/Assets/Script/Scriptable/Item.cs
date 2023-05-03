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

    public enum WaeponGrade
    {
        A,
        B,
        C,
        D,
    }

    public Sprite itemImage;
    public int quantity; //아이템 수량
    public bool stackable; // 저장...true면 한번에 처리할 수 있음... (동전같은 아이템)

    public ItemType itemType;
    public WaeponType waeponType;
    public WaeponGrade waeponGrade;
}
