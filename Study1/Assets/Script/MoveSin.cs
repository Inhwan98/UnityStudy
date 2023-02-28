using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSin : MonoBehaviour
{
    private float theta = 0f;
    public float speed_y = 1f;
    public float height = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        theta += speed_y * Time.deltaTime;
        pos.y = Mathf.Sin(theta) * height;

        this.transform.position = pos;
    }
}
