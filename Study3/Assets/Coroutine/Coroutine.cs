 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    IEnumerator Start()
    {
        //보스몹의 행동 패턴 A
        //yield는 기다리라는 뜻
        yield return MoveTo(Vector3.right, 1f);
        yield return MoveTo(Vector3.left, 1f);
        moveSpeed = 2f;
        yield return MoveTo(Vector3.up, 3f);
        moveSpeed = 5f;
        yield return MoveTo(Vector3.down, 3f);
    }

    public IEnumerator MoveTo(Vector3 dir, float duration)
    {
        float endTime = Time.time + duration;
        Debug.Log(endTime);
        while (true)
        {

            if (Time.time > endTime)
                break;

            this.transform.Translate(dir * moveSpeed * Time.deltaTime); // 거리/시간 = 속도
            yield return null;
        }
        
    }

   
}
