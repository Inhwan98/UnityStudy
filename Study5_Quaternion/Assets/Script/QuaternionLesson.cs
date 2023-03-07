using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionLesson : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotSpeed = 45f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //키보드 '1'을 눌렀을때 모든 적을 0으로 초기화 (리셋 버튼)
            transform.rotation = Quaternion.identity;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Quaternion newRotation = Quaternion.Euler(0, 0, 45);
            transform.rotation = newRotation;
        }

        // 문제2: 키보드로 좌우, 상하 입력을 받아서... 회전하시오
        // 좌우 -- y 축 회전
        // 상하 -- x 축 회전

        float rotY = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        float rotx = Input.GetAxis("Vertical") * rotSpeed * Time.deltaTime;

        //초당 45 스피드로 이동.
        this.transform.rotation = this.transform.rotation * Quaternion.Euler(rotx, rotY, 0);

    }
}
