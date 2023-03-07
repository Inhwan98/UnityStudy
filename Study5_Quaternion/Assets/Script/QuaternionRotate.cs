using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionRotate : MonoBehaviour
{
    public Transform childTransform;
    public Vector3 offset = new Vector3(0, 2, 0);
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        childTransform.localPosition = offset;

        //�θ�� Space.Self�� �ϳ� ����� �ϳ� ����.
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.A)) //�ڽ��� �ʴ� (0, 180, 0) ȸ�� (���� ����)
        {
            this.transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.D)) //�ڽ��� �ʴ� (0, 180, 0) ȸ�� (���� ����)
        {
            this.transform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime, Space.World);
        }
    }
}
