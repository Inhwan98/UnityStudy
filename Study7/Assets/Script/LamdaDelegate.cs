using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamdaDelegate : MonoBehaviour
{
    //��������Ʈ ����
    delegate float SumHandler(float a, float b);
    //��������Ʈ Ÿ���� ���� ����
    SumHandler sumHandler;

    //���� ������ �ϴ� �Լ�
    float Sum(float a, float b)
    {
        return a + b;
    }

    private void Start()
    {
        //��������Ʈ ������ �Լ�(�޼���) ����(�Ҵ�)
        sumHandler = Sum;
        float sum = sumHandler(10.0f, 5.0f);
        //�ᱣ�� ���
        Debug.Log($"Sum = {sum}");

        //��������Ʈ ������ ���ٽ� ����
        sumHandler = (float a, float b) => (a + b);
        float sum2 = sumHandler(10.0f, 5.0f);
        Debug.Log($"Sum = {sum}");

        //��������Ʈ ������ ���� �޼��� ����
        sumHandler = delegate (float a, float b) { return a + b; };
        float sum3 = sumHandler(2.0f, 3.0f);
        Debug.Log($"Sum3 = {sum3}");
    }
}
