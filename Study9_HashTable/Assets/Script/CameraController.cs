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

    // 반응 속도
    public float damping = 10.0f;

    // 카메라 LookAt의 Offset 값
    public float targetOffset = 2.0f;

    // SmoothDamp에서 사용할 변수
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
            // Camera를 피벗 좌표를 향해 회전
            camTr.LookAt(playerTr.position);
        }
        else
        {
            camTr.position = Vector3.SmoothDamp(camTr.position, // 시작 위치
                                              targetTr[0].position,            // 목표 위치
                                              ref velocity,   // 현재 속도
                                              damping - damping + 0.2f);       // 목표 위치까지 도달할 시간
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