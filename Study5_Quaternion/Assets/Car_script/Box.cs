using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{

    public float rot_speed = 45.0f;

    private void Start()
    {
        
    }

    void Update()
    {
        Vector3 vec = new Vector3(0, rot_speed, 0f);

        transform.Rotate(vec * Time.deltaTime);
 
        
    }

}
