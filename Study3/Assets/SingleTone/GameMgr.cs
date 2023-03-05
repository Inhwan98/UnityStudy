using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{

    public bool IsDie = false;
    public static GameMgr instance = null;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    //¿¹Á¦
    public void GameStart()
    {
        Debug.Log("GameStart");

    }

    public void GameEnd()
    {
        Debug.Log("GameEnd");
    }

    
}
