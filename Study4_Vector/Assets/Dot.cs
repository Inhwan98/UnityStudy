using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    public Transform A; // Cube : �÷��̾�
    public Transform B; // Sphere : ��


    void Start()
    {

       


    }

    // Update is called once per frame
    void Update()
    {

        // ��1) �÷��̾� ��ġ���� �� ��ġ�� ���ϴ� ����(���⺤��)�� ���Ͻÿ�.
        Vector3 dir = (B.position - A.position).normalized;

        float dot = Vector3.Dot(A.forward, dir);

        Debug.Log(dot);
        if (dot < 0)
        {
            Debug.Log("���� : 90�� ���� ũ��");
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(A.position, A.position + A.forward * 3f);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(A.position, B.position);
        
    }

}
