using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform playerTr;
    Transform cameraTr;

    public Vector3 offset = new Vector3(0, 5, -5);

    private void Start()
    {
        cameraTr = GetComponent<Transform>();
        playerTr = GameObject.Find("Player").transform;

        cameraTr.position =  playerTr.position + offset;
    }
        
    
    private void LateUpdate()
    {
        cameraTr.position = playerTr.position + offset;
        
        cameraTr.LookAt(playerTr.position);
    }
}
