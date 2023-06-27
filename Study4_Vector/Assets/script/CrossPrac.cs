using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossPrac : MonoBehaviour
{
    [SerializeField] private Transform playerTr;
    [SerializeField] private Transform enemyTr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curPos = playerTr.position;
        Vector3 targetPos = enemyTr.position;
        Vector3 cross = Vector3.Cross(curPos, targetPos);

        Debug.Log($"Cross : {cross}");
    }
}
