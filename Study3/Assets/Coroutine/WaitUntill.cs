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
        Debug.Log("������ ���� �Ҷ����� ��� ��...");
        yield return new WaitUntil(() => frame > 10); //lamda ���� ���ǽ�
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
