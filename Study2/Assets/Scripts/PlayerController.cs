using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; //이동 속력


    private void Start()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당

        playerRigidbody = this.GetComponent<Rigidbody>();
    }





    //1. 조작이(유저의 입력) 게임에 즉시 반영 되지 않는다. (AddForce 떄문. 힘을 중첩시켜 관성이 생긴다. 힘을 가동시킨다.)
    //2. 입력 감지 코드가 복잡하다.
#if (false)
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //위쪽방향키 입력이 감지된 경우 z 방향 힘 주기
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            //아래쪽 방향키 입력이 감지된 경우
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            //아래쪽 방향키 입력이 감지된 경우
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //아래쪽 방향키 입력이 감지된 경우
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }
#else



    //어떤 축에 대한 입력값을 숫자로 반환
    private void Update()
    {
        // 수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = yInput * speed;

        //Vector3 속도를 (xSpeed, 0, zSpeed)로 설정
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //리지드바디의 속력에 newVelocity 할당
        playerRigidbody.velocity = newVelocity;

    }
#endif


    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);

        //씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        GameManager gameManager = FindObjectOfType<GameManager>();
        //가져온 GameManager 오브젝트의 EndGame() 메서드 실행
        gameManager.EndGame();

    }
}

