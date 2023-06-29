using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_LamdaDelegate : MonoBehaviour
{
    private delegate int SumHandler(int a, int b);
    private SumHandler sumhandle;


    private delegate void PrintHandler();
    PrintHandler printHandler;


    private int PrintfAdd(int a, int b)
    {
        return a + b;
    }

    private int PrintfSub(int a, int b)
    {
        return a - b;
    }

    void printA()
    {
        Debug.Log("A");
    }

    void printB()
    {
        Debug.Log("B");
    }

    void Start()
    {
        sumhandle += PrintfAdd;
        sumhandle += PrintfSub;

        printHandler += printA;
        printHandler += printB;

        printHandler();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
