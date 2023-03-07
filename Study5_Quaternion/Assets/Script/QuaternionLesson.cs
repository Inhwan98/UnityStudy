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
            //Ű���� '1'�� �������� ��� ���� 0���� �ʱ�ȭ (���� ��ư)
            transform.rotation = Quaternion.identity;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Quaternion newRotation = Quaternion.Euler(0, 0, 45);
            transform.rotation = newRotation;
        }

        // ����2: Ű����� �¿�, ���� �Է��� �޾Ƽ�... ȸ���Ͻÿ�
        // �¿� -- y �� ȸ��
        // ���� -- x �� ȸ��

        float rotY = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        float rotx = Input.GetAxis("Vertical") * rotSpeed * Time.deltaTime;

        //�ʴ� 45 ���ǵ�� �̵�.
        this.transform.rotation = this.transform.rotation * Quaternion.Euler(rotx, rotY, 0);

    }
}
