using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InHwan
{
    public class CoroutineTest6 : MonoBehaviour
    {

        void Start()
        {

            StartCoroutine(TestRoutine());

        }

        public IEnumerator TestRoutine()
        {
            Debug.Log("Run TestRooutine");
            yield return StartCoroutine(OtherRoutine());
            Debug.Log("Finish TestRoutine");
        }

        IEnumerator OtherRoutine()
        {
            Debug.Log("Run OtherRoutine #1");
            yield return new WaitForSeconds(1f);
            Debug.Log("Run OtherRoutine #2");
            yield return new WaitForSeconds(1f);
            Debug.Log("Run OtherRoutine #3");
            yield return new WaitForSeconds(1f);
            Debug.Log("Run OtherRoutine");

        }


    }
}

