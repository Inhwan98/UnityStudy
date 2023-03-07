using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonVector : MonoBehaviour
{
   
    void Start()
    {
        Vector3 a, b, c, d;
        float length;

        //1. 스칼라 곱
        a = new Vector3(3, 6, 9);
        a = a * 10; // a (30, 60, 90);이 됨

        //2. 벡터의 덧셈과 뺄셈
        a = new Vector3(2, 4, 8);
        b = new Vector3(3, 6, 9);

        c = a + b; //c는 (5, 10, 17)이 됨
        d = a - b; //d는 (-1, -2, -1)이 됨

        //3. 벡터의 정규화 (방향벡터로 만들기)
        a = new Vector3(3, 3, 3);
        b = a.normalized; //b는 대략 ( 0.6, 0.6, 0.6)이 됨

        //4. 벡터의 크기(길이)
        a = new Vector3(3, 3, 3);
        length = a.magnitude; // b는 대략 5.19..가 됨

        //5. 벡터의 내적
        a = new Vector3(0, 1, 0); //위쪽을 향하는 벡터
        b = new Vector3(1, 0, 0); //오른쪽을 향하는 벡터

        //수직인 벡터끼리 내적하면 결과는 0, 벡터 b를 a로 투영한 길이가 됨
        length = Vector3.Dot(a, b);

        //6. 벡터의 외적
        a = new Vector3(0, 0, 1); // 앞쪽(z) 방향벡터
        b = new Vector3(1, 0, 0); // 오른쪽(x) 방향벡터

        //c는 (0,1,0)으로 두 벡터 모두의 수직인 벡터가 됨
        c = Vector3.Cross(a, b);

        //7. 두 지점 사이의 거리 Magnitude
        a = new Vector3(1, 0, 1); //현재 위치
        b = new Vector3(5, 3, 5); //목적지
        c = b - a; // a에서 b로 향하는 벡터 c는 (4,3,4)벡터가 됨
        length = c.magnitude; // length는 약 6.4가 됨

        //8. 두 지점 사이의 거리 Distance
        a = new Vector3(1, 0, 1); //현재 위치
        b = new Vector3(5, 3, 5); //목적지
        length = Vector3.Distance(a, b);

        //9. 현재 위치에서 목적지로 향해 10만큼 이동하기
        a = new Vector3(1, 0, 1); //현재 위치
        b = new Vector3(5, 3, 5); //목적지
        // a에서 b로 향하는 방향 벡터 c는 (0.6, 0.5, 0.6)이 됨
        c = (b - a).normalized;
        // 목적지를 향해 10 만큼 현재 위치에서 이동한 새로운 위치 (7.2, 4.7, 7.2)가 됨
        d = a + c * 10;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
