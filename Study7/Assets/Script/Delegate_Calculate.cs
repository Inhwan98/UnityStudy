using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_Calculate : MonoBehaviour
{
    delegate float Calculate(float a, float b);

    Calculate onCalculate;

    int allCount;

    void Start()
    {
        onCalculate = Sum;
        onCalculate += Subtract;
        onCalculate -= Subtract;
        onCalculate += Multiply;
    }

    public float Sum(float a, float b)
    {
        allCount++;
        Debug.Log(allCount);
        return a + b;
    }

    public float Subtract(float a, float b)
    {
        allCount++;
        Debug.Log(allCount);
        return a - b;
    }

    public float Multiply(float a, float b)
    {
        allCount++;
        Debug.Log(allCount);
        return a * b;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("°á°ú°ª: " + onCalculate(1, 10));
        }
    }
}
