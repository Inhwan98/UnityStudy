using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCotroller : MonoBehaviour
{
    public float speed = 5.0f;
    float v, h;
    Rigidbody rigid;
    Transform tr;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 dir = (Vector3.forward * v) + (Vector3.right * h);
        rigid.velocity = dir * speed;

        Debug.Log(Input.mousePosition);
    }
}
