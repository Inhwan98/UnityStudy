using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    public float turnspeed = 45.0f;

    private void LateUpdate()
    {
        transform.position = target.position + offset;
       

    }

}