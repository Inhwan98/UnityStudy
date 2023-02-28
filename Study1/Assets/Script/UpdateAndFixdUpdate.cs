using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixdUpdate : MonoBehaviour
{
    float fixedupdateTimer;
    float UpdateTimer;


    private void FixedUpdate()
    {
        Debug.Log($"FinxedUpdate time : {Time.deltaTime}");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Update time : {Time.deltaTime}");
    }
}
