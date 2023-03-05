using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InHwan;


public class CoroutineTest2 : MonoBehaviour
{
    public int[] numbers;

    void Start()
    {
        //배열로 선언된 내용을 순차적으로 출력해준다.
        foreach (var num in numbers)
        {
            Debug.Log(num);
        }

        foreach (var number in SomNumber())
        {
            Debug.Log(numbers);
        }

    }

    IEnumerable SomNumber()
    {
        yield return 3;
        yield return 6;
        yield return 9;
    }

}
