using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckController : MonoBehaviour
{

    [Header("Move Setting")]
    [SerializeField] private float turnSpeed = 50.0f;
    [SerializeField] private float moveSpeed = 10.0f;

    [SerializeField] private float offDistanse = 5f;

    private Rigidbody rigid;


    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotX = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 zSpeed = transform.forward * z * moveSpeed;
        Quaternion rotYSpeed = Quaternion.Euler(transform.up * rotX * turnSpeed * Time.deltaTime);


        rigid.velocity = zSpeed;
        rigid.rotation *= rotYSpeed;
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Box"))
        {
            
            coll.transform.parent = this.transform;
            coll.transform.position = this.transform.position - (transform.forward * offDistanse);
            offDistanse += 3f;
        }
    }
}

