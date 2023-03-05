using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    private IEnumerator m_Coroutine;

    void Start()
    {
       m_Coroutine = CoroutineMethod();
       StartCoroutine(m_Coroutine); //�ڷ�ƾ�� �����ϴ� �Լ�
    }

    IEnumerator CoroutineMethod()
    {
        Debug.Log("����");
        yield return new WaitForSeconds(1f);
        Debug.Log("1�� ��....");

        while (true)
        {
            Debug.Log("1��....");
            yield return new WaitForSeconds(1);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (m_Coroutine != null){
                Debug.Log("Stop");
                StopCoroutine(m_Coroutine);
            }
        }
    }

}
