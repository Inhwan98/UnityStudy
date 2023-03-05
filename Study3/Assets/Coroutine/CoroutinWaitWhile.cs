
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
        Debug.Log("������ ���� ���� ���� �� ���� ��� ��...");
        yield return new WaitWhile(() => frame <= 10); //lamda ���� ���ǽ�
        Debug.Log("�Ϸ�");
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
