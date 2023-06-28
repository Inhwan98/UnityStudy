using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDelegate : MonoBehaviour
{
    //델리게이트 선언
    public delegate void PlayerDieHandler();

    //이벤트 선언
    public static event PlayerDieHandler OnPlayerDie;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerDie()
    {
        Debug.Log("Player Die!");
        OnPlayerDie();
    }

    private void OnDisable()
    {
        PlayerDie();
    }
}
