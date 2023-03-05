using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineStart : MonoBehaviour
{
    private IEnumerator m_Coroutine;
    private void Start()
    {
        m_Coroutine = CoroutineMethod();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // 1. CoroutineMethod1 시작, 3. StopCoroutine 후 멈춘 위치에서 다시 계속
            StartCoroutine(m_Coroutine);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            // 2-1 CoroutineMethod1 일시정지
            StopCoroutine(m_Coroutine);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            // 2-2 CoroutineMethod1, CoroutineMethod2 일시정지
            StopAllCoroutines();
        }

    }

    IEnumerator CoroutineMethod()
    {
        int count = 0;

        while (true)
        {
            Debug.Log(count);
            yield return new WaitForSeconds(1.0f);
            count++;
        }
    }



}

