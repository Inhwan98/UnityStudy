using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTone_Lazy : MonoBehaviour
{
    private static SingleTone_Lazy instance;
    public static SingleTone_Lazy GetInstance()
    {
        if (!instance)
        {
            instance = GameObject.FindObjectOfType(typeof(SingleTone_Lazy)) as SingleTone_Lazy;
            if (!instance)
            {
                GameObject obj = new GameObject("GameMangers");
                instance = obj.AddComponent(typeof(SingleTone_Lazy)) as SingleTone_Lazy;
            }
        }
        return instance;
        // Update is called once per frame

    }
}
