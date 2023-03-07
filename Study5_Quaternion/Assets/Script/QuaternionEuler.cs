using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionEuler : MonoBehaviour
{
    public float speed = 45.0f;
    private float angle;



    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        this.transform.rotation = Quaternion.Euler(0, angle, 0);
    }
}
