using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireUpdate : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;

    private float lastFireTime;
    private float coolTime = 1f;

    void Start()
    {
        lastFireTime = Time.time;

    }

    
    void Update()
    {
           if(Time.time - lastFireTime >= coolTime)
        {
            Instantiate(bullet, firePos.position, Quaternion.identity);
            lastFireTime = Time.time;
        }
    }
}
