using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonVector : MonoBehaviour
{
   
    void Start()
    {
        Vector3 a, b, c, d;
        float length;

        //1. ��Į�� ��
        a = new Vector3(3, 6, 9);
        a = a * 10; // a (30, 60, 90);�� ��

        //2. ������ ������ ����
        a = new Vector3(2, 4, 8);
        b = new Vector3(3, 6, 9);

        c = a + b; //c�� (5, 10, 17)�� ��
        d = a - b; //d�� (-1, -2, -1)�� ��

        //3. ������ ����ȭ (���⺤�ͷ� �����)
        a = new Vector3(3, 3, 3);
        b = a.normalized; //b�� �뷫 ( 0.6, 0.6, 0.6)�� ��

        //4. ������ ũ��(����)
        a = new Vector3(3, 3, 3);
        length = a.magnitude; // b�� �뷫 5.19..�� ��

        //5. ������ ����
        a = new Vector3(0, 1, 0); //������ ���ϴ� ����
        b = new Vector3(1, 0, 0); //�������� ���ϴ� ����

        //������ ���ͳ��� �����ϸ� ����� 0, ���� b�� a�� ������ ���̰� ��
        length = Vector3.Dot(a, b);

        //6. ������ ����
        a = new Vector3(0, 0, 1); // ����(z) ���⺤��
        b = new Vector3(1, 0, 0); // ������(x) ���⺤��

        //c�� (0,1,0)���� �� ���� ����� ������ ���Ͱ� ��
        c = Vector3.Cross(a, b);

        //7. �� ���� ������ �Ÿ� Magnitude
        a = new Vector3(1, 0, 1); //���� ��ġ
        b = new Vector3(5, 3, 5); //������
        c = b - a; // a���� b�� ���ϴ� ���� c�� (4,3,4)���Ͱ� ��
        length = c.magnitude; // length�� �� 6.4�� ��

        //8. �� ���� ������ �Ÿ� Distance
        a = new Vector3(1, 0, 1); //���� ��ġ
        b = new Vector3(5, 3, 5); //������
        length = Vector3.Distance(a, b);

        //9. ���� ��ġ���� �������� ���� 10��ŭ �̵��ϱ�
        a = new Vector3(1, 0, 1); //���� ��ġ
        b = new Vector3(5, 3, 5); //������
        // a���� b�� ���ϴ� ���� ���� c�� (0.6, 0.5, 0.6)�� ��
        c = (b - a).normalized;
        // �������� ���� 10 ��ŭ ���� ��ġ���� �̵��� ���ο� ��ġ (7.2, 4.7, 7.2)�� ��
        d = a + c * 10;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
