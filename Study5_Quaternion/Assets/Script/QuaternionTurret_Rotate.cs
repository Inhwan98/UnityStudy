using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionTurret_Rotate : MonoBehaviour
{
    public Transform cannon;
    public float rotSpeed = 45f;
 
    // Update is called once per frame
    void Update()
    {
        float yRot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        float xRot = Input.GetAxis("Vertical") * rotSpeed * Time.deltaTime;

        //1) 포탑 회전 (y) ... Horizontal
        Vector3 y = new Vector3(0, yRot, 0);

        this.transform.Rotate(y);
        //2) 포신 회전 (x) ... Vertical
        Vector3 x = new Vector3(-xRot, 0, 0);
        cannon.transform.Rotate(x, Space.Self);


        

        //float h = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        //float v = Input.GetAxis("Vertical") * rotSpeed * Time.deltaTime;
        ////this.transform.Rotate(Vector3.up * h * rotSpeed * Time.deltaTime);
        ////cannon.Rotate(Vector3.right * v * rotSpeed * Time.deltaTime);





    }
}
