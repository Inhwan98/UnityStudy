using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPosition : MonoBehaviour
{
    public Transform dest; //������ ��� ������Ʈ
    public float distance = 1; //������� �Ÿ�
    private void OnEnable()
    {
        //��� ������Ʈ�� �θ� ���� �����Ѵ�
        dest.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        //�� ��ġ�� �������� ��� ������Ʈ�� �����Ÿ� ������ ��ġ(������� �Ÿ�)�� ��ġ
        dest.localPosition = this.transform.position +
            new Vector3(0f, distance, 0f);
    }
}
