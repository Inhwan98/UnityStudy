using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f; //�̵� �ӷ�


    private void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�

        playerRigidbody = this.GetComponent<Rigidbody>();
    }





    //1. ������(������ �Է�) ���ӿ� ��� �ݿ� ���� �ʴ´�. (AddForce ����. ���� ��ø���� ������ �����. ���� ������Ų��.)
    //2. �Է� ���� �ڵ尡 �����ϴ�.
#if (false)
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //���ʹ���Ű �Է��� ������ ��� z ���� �� �ֱ�
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            //�Ʒ��� ����Ű �Է��� ������ ���
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            //�Ʒ��� ����Ű �Է��� ������ ���
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //�Ʒ��� ����Ű �Է��� ������ ���
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }
#else



    //� �࿡ ���� �Է°��� ���ڷ� ��ȯ
    private void Update()
    {
        // ������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = yInput * speed;

        //Vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //������ٵ��� �ӷ¿� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;

    }
#endif


    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);

        //���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        GameManager gameManager = FindObjectOfType<GameManager>();
        //������ GameManager ������Ʈ�� EndGame() �޼��� ����
        gameManager.EndGame();

    }
}

