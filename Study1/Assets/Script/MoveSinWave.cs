using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSinWave : MonoBehaviour
{
    private float theta = 0f;
    public float speed_x = 5;
    public float speed_y = 20f;
    public float height = 0.5f;
    bool facingRight = true;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (pos.x < -7f)
            facingRight = true;
        else if (pos.x > 7f)
            facingRight = false;

        //xÁÂÇ¥
        if (facingRight)
            pos.x += Time.deltaTime * speed_x;
        else
            pos.x -= Time.deltaTime * speed_x;

        //yÁÂÇ¥
        theta += Time.deltaTime * speed_y;
        pos.y = Mathf.Sin(theta) * height;

        transform.position = pos;
    }
}
