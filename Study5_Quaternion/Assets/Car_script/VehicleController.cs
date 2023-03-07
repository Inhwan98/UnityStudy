using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{

    public GameObject Box_Pre;
    public float moveSpeed = 20.0f;
    public float turnspeed = 45.0f;

    public Vector3 offset;

    private float fowardInput;
    private float horizontalInput;

    private float count;
    private bool isCrash;

    void Start()
    {
        count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        fowardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //앞으로 이동 : fowardInput
        transform.Translate(Vector3.forward * fowardInput * moveSpeed * Time.deltaTime);

        //좌우로 회전 : horizontalInput
        transform.Rotate(Vector3.up * horizontalInput * turnspeed * Time.deltaTime);


    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Box")
        {
            offset.z = offset.z + count;
            GameObject box = Instantiate(Box_Pre, transform.position, transform.rotation);
            box.transform.position = this.transform.position + offset;

            float distance = Vector3.Distance(transform.position, box.transform.position);
            offset += -transform.forward * distance;

            //box.transform.Translate()
        }
    }
}

    