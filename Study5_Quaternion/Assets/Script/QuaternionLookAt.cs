using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionLookAt : MonoBehaviour
{
    public Transform targetObj;
    public float speed = 5f;
    Color color;

    void Update()
    {
        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        targetObj.Translate(h, v, 0);

        if (h != 0)
        {
            color = Color.blue;
            this.transform.rotation = Quaternion.LookRotation(targetObj.position - this.transform.position);
        }       
        else
        {
            color = Color.red;
            this.transform.LookAt(targetObj);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawRay(this.transform.position, transform.forward * 10f);
    }
}

