using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPosition : MonoBehaviour
{
    public Transform dest; //움직일 대상 오브젝트
    public float distance = 1; //상대적인 거리
    private void OnEnable()
    {
        //대상 오브젝트의 부모를 나로 지정한다
        dest.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        //내 위치를 기준으로 대상 오브젝트를 일정거리 떨어진 위치(상대적인 거리)에 배치
        dest.localPosition = this.transform.position +
            new Vector3(0f, distance, 0f);
    }
}
