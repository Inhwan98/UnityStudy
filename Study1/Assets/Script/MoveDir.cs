using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDir : MonoBehaviour
{
    public float height = 1f;
    public float dir = 1f;
    public float step = 1f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= height)
        {
            dir = -1;
        }
        else if (transform.position.y <= 0)
        {
            dir = 1;
        }

        Vector3 _newPosition = transform.position;
        _newPosition.y = _newPosition.y + dir * Time.deltaTime * step;
        Debug.Log(_newPosition.y);
        transform.position = _newPosition;

    }
}
