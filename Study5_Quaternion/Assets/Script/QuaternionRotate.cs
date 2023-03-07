using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionRotate : MonoBehaviour
{
    public Transform childTransform;
    public Vector3 offset = new Vector3(0, 2, 0);
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        childTransform.localPosition = offset;

        //부모는 Space.Self로 하나 월드로 하나 같다.
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.A)) //자식을 초당 (0, 180, 0) 회전 (로컬 공간)
        {
            this.transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.D)) //자식을 초당 (0, 180, 0) 회전 (로컬 공간)
        {
            this.transform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime, Space.World);
        }
    }
}
