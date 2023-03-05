using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitUntill : MonoBehaviour
{

    private int frame = 0;

    void Start()
    {
        StartCoroutine(Example());

    }

    IEnumerator Example()
    {
        Debug.Log("조건을 만족 할때까지 대기 중...");
        yield return new WaitUntil(() => frame > 10); //lamda 식의 조건식
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
