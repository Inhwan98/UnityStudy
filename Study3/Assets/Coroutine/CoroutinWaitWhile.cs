
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinWaitWhile : MonoBehaviour
{

    private int frame = 0;

    void Start()
    {
        StartCoroutine(Example());

    }

    IEnumerator Example()
    {
        Debug.Log("조건을 만족 하지 않을 때 까지 대기 중...");
        yield return new WaitWhile(() => frame <= 10); //lamda 식의 조건식
        Debug.Log("완료");
    }

    private void Update()
    {
        if (frame <= 10)
        {
            Debug.Log("Frame : " + frame);
            frame++;
        }
    }

}
