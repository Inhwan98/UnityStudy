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
        //Ű���� '1'�� �������� ��� ���� 0���� �ʱ�ȭ (���� ��ư)
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.transform.rotation = Quaternion.identity;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Quaternion _newRotation = Quaternion.Euler(0, 0, 45);
            this.transform.rotation = _newRotation;
        }
        // ����2: Ű����� �¿�, ���� �Է��� �޾Ƽ�... ȸ���Ͻÿ�
        xSpeed = Input.GetAxis("Vertical") * rotSpeed * Time.deltaTime;
        ySpeed = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        this.transform.rotation *= Quaternion.Euler(-xSpeed, ySpeed, 0);

    }
}
