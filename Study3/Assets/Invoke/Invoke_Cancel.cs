using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_Cancel : MonoBehaviour
{
    int m_nCount = 0;

    void Start()
    {
        Debug.Log("Start()");
        InvokeRepeating("FuncInvoke", 5.0f, 1.0f);

    }

    void FuncInvoke()
    {
        m_nCount++;
        Debug.Log("FuncInvoke()");

        if( m_nCount >= 5)
        {
            CancelInvoke("FuncInvoke");
        }
    }

}
