using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalPosition : MonoBehaviour
{
    public Transform dest; //������ ��� ������Ʈ
    public float distance = 1; //������� �Ÿ�


    void OnEnable()
    {
        //��� ������Ʈ�� �θ� ���� �����Ѵ�
        dest.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //�� ��ġ�� �������� ��� ������Ʈ�� �����Ÿ� ������ ��ġ(������� �Ÿ�)�� ��ġ
        dest.localPosition = this.transform.position +
            new Vector3(0f, distance, 0f);
    }
}
