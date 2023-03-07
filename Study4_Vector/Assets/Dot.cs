using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    public Transform A; // Cube : 플레이어
    public Transform B; // Sphere : 적


    void Start()
    {

       


    }

    // Update is called once per frame
    void Update()
    {

        // 문1) 플레이어 위치에서 적 위치로 향하는 벡터(방향벡터)를 구하시오.
        Vector3 dir = (B.position - A.position).normalized;

        float dot = Vector3.Dot(A.forward, dir);

        Debug.Log(dot);
        if (dot < 0)
        {
            Debug.Log("뒤쪽 : 90도 보다 크다");
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
