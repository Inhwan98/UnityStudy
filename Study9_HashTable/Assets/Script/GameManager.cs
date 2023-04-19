using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inhwan.HashTable;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public HashTable<Item.WaeponGrade> h;
    Hashtable aa = new Hashtable();
    

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);

    }

    void Start()
    {
        h = new HashTable<Item.WaeponGrade>(20);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HashPut(string name, Item.WaeponGrade context)
    {
        if (h.get(name) != null)
        {
            h.put(name, context);
        }
        else
        {
            Debug.Log("이미 있습니다.");
        }

    }

}