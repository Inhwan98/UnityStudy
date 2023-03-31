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
        //���� ������ target�� ī�޶��� ��ġ�� �������� distance�� �ʱ�ȭ
        distance = Vector3.Distance(transform.position, target.position);
        //���� ī�޶��� ȸ�� ���� x, y ������ ����
        Vector3 angles = transform.eulerAngles;
        horizontal = angles.y; //x, z �ప�� ����ȴ�.
        vertical = angles.x; //x, z �ప�� ����ȴ�.

        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        //target������ ����x
        if (target == null) return;

        horizontal += Input.GetAxis("Mouse X") * xMoveSpeed * Time.deltaTime;
        vertical -= Input.GetAxis("Mouse Y") * yMoveSpeed * Time.deltaTime;

        //���콺 x, y�� ������ ���� ����
        vertical = ClampAngle(vertical, yMinLimit, yMaxLimit);
        
        //ī�޶��� ȸ��(Rotation)���� ����
        transform.rotation = Quaternion.Euler(vertical, horizontal, 0);

        //���콺 �� ��ũ���� �̿��� target�� ī�޶��� �Ÿ� ��(distance) ����
        distance -= Input.GetAxis("Mouse ScrollWheel") * wheelSpeed * Time.deltaTime;
        //�Ÿ��� �ּ�, �ִ� �Ÿ��� �����ؼ� �� ���� ����� �ʵ��� �Ѵ�.
        distance = Mathf.Clamp(distance, minDistance, maxDistance);
    }
    private void LateUpdate()
    {

        if (target == null) return;

        //ī�޶��� ��ġ(Position) ���� ����
        //target�� ��ġ�� �������� distance��ŭ �������� �Ѿư���.
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