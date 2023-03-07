using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    public float rotSpeed = 45f;
    float xSpeed;
    float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        //키보드 '1'을 눌렀을때 모든 적을 0으로 초기화 (리셋 버튼)
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.transform.rotation = Quaternion.identity;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Quaternion _newRotation = Quaternion.Euler(0, 0, 45);
            this.transform.rotation = _newRotation;
        }
        // 문제2: 키보드로 좌우, 상하 입력을 받아서... 회전하시오
        xSpeed = Input.GetAxis("Vertical") * rotSpeed * Time.deltaTime;
        ySpeed = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        this.transform.rotation *= Quaternion.Euler(-xSpeed, ySpeed, 0);

    }
}
