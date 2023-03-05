using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineStop : MonoBehaviour
{
    private IEnumerator coroutine;

    void Start()
    {
        coroutine = WaitAndPrint(1.0f);
        StartCoroutine(coroutine);

    }

    IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Debug.Log("waitAndPrint" + Time.time);
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StopCoroutine(coroutine);
            Debug.Log("Stopped" + Time.time);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StopAllCoroutines();
            Debug.Log("Stopped All" + Time.time);
        }
    }
}
