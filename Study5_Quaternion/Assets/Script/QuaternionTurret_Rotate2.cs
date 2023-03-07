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
         *  0 ~ 360도 입력된 값을 -> -180 ~ 180 도로 변환한다.
         */
        angle %= 360;

        if (angle > 180)
            return angle - 360;

        return angle;

    }

    // Update is called once per frame
    void Update()
    {
        //수평축 (좌우로 회전)
        rotationY += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        this.transform.rotation = Quaternion.Euler(0, rotationY, 0);

        //수직축(위아래로 회전)
        rotationX += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //cannon.localEulerAngles = new Vector3(rotationX, 0, 0);

        //Mathf.Clamp : 최소 /  최대값을 설정하여 float 값이 범위 이외의 값을ㅇ 넘지 않도록

        rotationX = Mathf.Clamp(rotationX, min, max);
        cannon.localEulerAngles = new Vector3(rotationX, 0, 0);


        //Debug.Log($"캐논 X : {cannon.localEulerAngles.x }");
        //Debug.Log($"캐논 X : {WrapAngle( cannon.localEulerAngles.x) }");

        //if ( cannon.localEulerAngles.x < -45)
    }
}
