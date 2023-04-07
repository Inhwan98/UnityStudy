using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixdUpdate : MonoBehaviour
{
    float fixedupdateTimer;
    float UpdateTimer;


    // 사용자 지정 프레임 가능
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
