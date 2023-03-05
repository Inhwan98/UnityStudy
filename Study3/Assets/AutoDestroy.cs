using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float lifeTimer = 3f;

    void Start()
    {
        Destroy(this.gameObject, lifeTimer);
    }

    // Update is called once per frame
    
    }
