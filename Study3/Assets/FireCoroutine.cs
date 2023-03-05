using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCoroutine : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;

    
    void Start()
    {
        
        StartCoroutine(Fire(1f));

    }

    private IEnumerator Fire(float coolTime)
    {
        
        while ( true)
        {

            yield return new WaitForSeconds(coolTime);
            Instantiate(bullet, firePos.position, Quaternion.identity);
            
            
        }
    }
    
    
}
