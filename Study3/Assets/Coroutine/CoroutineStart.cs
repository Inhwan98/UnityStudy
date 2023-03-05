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
            // 1. CoroutineMethod1 ����, 3. StopCoroutine �� ���� ��ġ���� �ٽ� ���
            StartCoroutine(m_Coroutine);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            // 2-1 CoroutineMethod1 �Ͻ�����
            StopCoroutine(m_Coroutine);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            // 2-2 CoroutineMethod1, CoroutineMethod2 �Ͻ�����
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

