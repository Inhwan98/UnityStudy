using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    private IEnumerator m_Coroutine;

    void Start()
    {
       m_Coroutine = CoroutineMethod();
       StartCoroutine(m_Coroutine); //코루틴을 시작하는 함수
    }

    IEnumerator CoroutineMethod()
    {
        Debug.Log("시작");
        yield return new WaitForSeconds(1f);
        Debug.Log("1초 후....");

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
            if (m_Coroutine != null){
                Debug.Log("Stop");
                StopCoroutine(m_Coroutine);
            }
        }
    }

}
