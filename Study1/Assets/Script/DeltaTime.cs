using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    float a = 0.0f;
    float b = 0.0f;
    
    float CounterA()
    {
        //�����Ӵ� �ϳ��� ���ϴ� ���
        return a += 1.0f;
    }

    float CounterB()
    {
        //�ʴ�
        return b += 1.0f * Time.deltaTime;
    }

    void Update()
    {
        Debug.Log($"A : {(int)CounterA()}, B : {(int)CounterB()}");
    }
}
