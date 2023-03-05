 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    IEnumerator Start()
    {
        //�������� �ൿ ���� A
        //yield�� ��ٸ���� ��
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

            this.transform.Translate(dir * moveSpeed * Time.deltaTime); // �Ÿ�/�ð� = �ӵ�
            yield return null;
        }
        
    }

   
}
