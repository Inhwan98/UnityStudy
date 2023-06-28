using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterUseDelegate : MonoBehaviour
{

    private void OnEnable()
    {
        PlayerDelegate.OnPlayerDie += this.OnPlayerDie;
    }

    private void OnDisable()
    {
        PlayerDelegate.OnPlayerDie -= this.OnPlayerDie;
    }


    void OnPlayerDie()
    {
        //
        string name = this.gameObject.name;
        Debug.Log($"Monster Name : {name}");
    }
}
