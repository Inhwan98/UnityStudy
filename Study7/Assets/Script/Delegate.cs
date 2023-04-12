using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{
    //��������Ʈ ����
    delegate float SumHandler(float a, float b);
    // ��������Ʈ Ÿ���� ���� ����
    SumHandler sumHandler;

    // ���� ������ �ϴ� �Լ�
    float Sum(float a, float b)
    {
        return a + b;
    }

    private void Start()
    {
        //��������Ʈ ������ �Լ�(�޼���) ����(�Ҵ�)
        sumHandler = Sum;
        // ��������Ʈ ����
        float sum = sumHandler(10.0f, 5.0f);
        // �ᱣ�� ���
        Debug.Log($"Sum = {sum}");

    }



}