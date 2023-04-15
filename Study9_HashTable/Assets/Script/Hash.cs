using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inhwan.HashTable
{
    public class Hash : MonoBehaviour
    {
        public HashTable<string> h;

        private void Awake()
        {
            h = new HashTable<string>(3 );
        }

        private void Start()
        {
            h.put("park", "He is cool");
            h.put("sung", "He is pretty");
            h.put("jin", "He is a model");
            h.put("hee", "He is an angel");
            h.put("min", "He is cute");
            Debug.Log(h.get("park"));
            Debug.Log(h.get("sung"));
            Debug.Log(h.get("jin"));
            Debug.Log(h.get("hee"));
            Debug.Log(h.get("jae"));
        }
    }
}

