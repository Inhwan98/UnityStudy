using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionAngleAxis : MonoBehaviour
{
    public float speed = 45.0f;
    public Vector3 axis = Vector3.left;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ������ ���� �������� �� ȸ���� ���
        Quaternion q = Quaternion.AngleAxis(speed * Time.deltaTime, axis);

        // ���� ȸ�������� ȸ���� �� (�߰�) ������
        transform.rotation = transform.rotation *  q;


    }
}
