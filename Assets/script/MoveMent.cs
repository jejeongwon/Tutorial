using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    // const : 상수
    // 실행 중에 값이 변경될 수 없는 것이다.
    const int a = 4;

    int b = 100;

   //a라는 상수에는 값을 저장할 수 없지만 a를 가지고 연산을 수행하는 것은 가능하다.

    // Start is called before the first frame update
    void Start()
    {
       // a라는 메모리 공간 계속 바뀔 수 있다.
        
        Debug.Log(a + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
