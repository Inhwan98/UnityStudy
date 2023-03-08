using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    float distance;
    float horizontal;
    float vertical;
    float wheelSpeed = 10.0f;

    float yMinLimit = -20.0f;
    float yMaxLimit = 80f;
    float minDistance = 10.0f;
    float maxDistance = 20.0f;
    float xMoveSpeed = 220.0f;
    float yMoveSpeed = 100.0f;

    private void Awake()
    {
        //최초 설정된 target과 카메라의 위치를 바탕으로 distance값 초기화
        distance = Vector3.Distance(transform.position, target.position);
        //최초 카메라의 회전 값을 x, y 변수에 저장
        Vector3 angles = transform.eulerAngles;
        horizontal = angles.y; //x, z 축값이 변경된다.
        vertical = angles.x; //x, z 축값이 변경된다.

        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        //target없으면 실행x
        if (target == null) return;

        horizontal += Input.GetAxis("Mouse X") * xMoveSpeed * Time.deltaTime;
        vertical -= Input.GetAxis("Mouse Y") * yMoveSpeed * Time.deltaTime;

        //마우스 x, y축 움직임 방향 정보
        vertical = ClampAngle(vertical, yMinLimit, yMaxLimit);
        
        //카메라의 회전(Rotation)정보 갱신
        transform.rotation = Quaternion.Euler(vertical, horizontal, 0);

        //마우스 휠 스크롤을 이용해 target과 카메라의 거리 값(distance) 조절
        distance -= Input.GetAxis("Mouse ScrollWheel") * wheelSpeed * Time.deltaTime;
        //거리는 최소, 최대 거리를 설정해서 그 값을 벗어나지 않도록 한다.
        distance = Mathf.Clamp(distance, minDistance, maxDistance);
    }
    private void LateUpdate()
    {

        if (target == null) return;

        //카메라의 위치(Position) 정보 갱신
        //target의 위치를 기준으로 distance만큼 떨어져서 쫓아간다.
        //Vector3 offset = transform.rotation * new Vector3(0, 0, -distance);
        //Debug.Log($" Q * V = {offset} / transform.forward {-this.transform.forward * distance}");

        Vector3 offset = -this.transform.forward * distance;
        offset = transform.rotation * new Vector3(0, 0, -distance);
        transform.position = offset + target.position;
    }


    float ClampAngle(float angle, float min, float max)

    {

        if (angle < -360)

            angle += 360;

        if (angle > 360)

            angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }

}