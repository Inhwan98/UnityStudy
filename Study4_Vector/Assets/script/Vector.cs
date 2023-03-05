using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    void Start()
    {
        Vector3 a = new Vector3(0, 0, 0);
        Vector3 b = a;
        b.x = 100;

        Debug.Log($"a:{a}, b:{b}");

        Vector3 pos1 = new Vector3(1, 0, 0);
        //pos1.x = 1; // (1, 0, 0)
        this.transform.position = pos1;

        //x,y,z를 모두다 초기화하면 new Vector3를 안해도 된다.
        Vector3 pos2;
        pos2.x = 1;
        pos2.y = 1;
        pos2.z = 1;
        this.transform.position = pos2;

    }

    void Update()
    {
        
    }
}
