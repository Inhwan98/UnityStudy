using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest1 : MonoBehaviour
{
    private IEnumerator m_Coroutine;


    IEnumerator CoroutineMethod()
    {
       
        while (true)
        {
            Debug.Log("1초....");
            yield return new WaitForSeconds(1);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Full Hp");

            if (m_Coroutine != null){
                Debug.Log("Stop");
                StopCoroutine(m_Coroutine);
            }

            m_Coroutine = CoroutineMethod();
            StartCoroutine(m_Coroutine); //코루틴을 시작하는 함수

        }
    }

}
