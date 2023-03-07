 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionTurret_Rotate2 : MonoBehaviour
{
    public Transform cannon;
    public float speed = 50.0f;

    public float rotationX = 0;
    private float rotationY = 0;

    public float min = -45f;
    public float max = 45f;

    float WrapAngle(float angle)
    {
        /*
         *  0 ~ 360�� �Էµ� ���� -> -180 ~ 180 ���� ��ȯ�Ѵ�.
         */
        angle %= 360;

        if (angle > 180)
            return angle - 360;

        return angle;

    }

    // Update is called once per frame
    void Update()
    {
        //������ (�¿�� ȸ��)
        rotationY += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        this.transform.rotation = Quaternion.Euler(0, rotationY, 0);

        //������(���Ʒ��� ȸ��)
        rotationX += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //cannon.localEulerAngles = new Vector3(rotationX, 0, 0);

        //Mathf.Clamp : �ּ� /  �ִ밪�� �����Ͽ� float ���� ���� �̿��� ������ ���� �ʵ���

        rotationX = Mathf.Clamp(rotationX, min, max);
        cannon.localEulerAngles = new Vector3(rotationX, 0, 0);


        //Debug.Log($"ĳ�� X : {cannon.localEulerAngles.x }");
        //Debug.Log($"ĳ�� X : {WrapAngle( cannon.localEulerAngles.x) }");

        //if ( cannon.localEulerAngles.x < -45)
    }
}
