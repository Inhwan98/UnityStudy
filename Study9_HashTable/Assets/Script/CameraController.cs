using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance = null;

    Transform playerTr;
    Transform[] targetTr;
    Transform camTr;

    public Vector3 offset = new Vector3(0, 5, -4);

    // ���� �ӵ�
    public float damping = 10.0f;

    // ī�޶� LookAt�� Offset ��
    public float targetOffset = 2.0f;

    // SmoothDamp���� ����� ����
    private Vector3 velocity = Vector3.zero;

    private bool IsOtherUse;
    public bool isOtherUse
    {
        get => IsOtherUse;
        set
        {
            IsOtherUse = value;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        camTr = GetComponent<Transform>();
        playerTr = GameObject.Find("Player").transform;
        targetTr = new Transform[2];
    }


    private void LateUpdate()
    {
        if (!isOtherUse)
        {
            camTr.position = playerTr.position + offset;
            // Camera�� �ǹ� ��ǥ�� ���� ȸ��
            camTr.LookAt(playerTr.position);
        }
        else
        {
            camTr.position = Vector3.SmoothDamp(camTr.position, // ���� ��ġ
                                              targetTr[0].position,            // ��ǥ ��ġ
                                              ref velocity,   // ���� �ӵ�
                                              damping - damping + 0.2f);       // ��ǥ ��ġ���� ������ �ð�
            camTr.LookAt(targetTr[1].position);
        }

    }

    public void ChangeTarget(Transform changeTr, Transform looktargetTr)
    {
        IsOtherUse = true;
        targetTr[0] = changeTr;
        targetTr[1] = looktargetTr;
    }

}