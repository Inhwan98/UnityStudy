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
        // 지정된 축을 기준으로 한 회전값 계산
        Quaternion q = Quaternion.AngleAxis(speed * Time.deltaTime, axis);

        // 현재 회전값에서 회전이 더 (추가) 해진다
        transform.rotation = transform.rotation *  q;


    }
}
