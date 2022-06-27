using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    // Start is called before the first frame update
    //int : 정수를 저장할 수있는 자료형(4byte)
    //float : 실수를 저장할 수 있는 자료형(4byte)
    //char : 하나의 문자만 저장할 수 있는 자료형(1byte)
    //char에 정수를 저장할 수 있다.
    // string : hello 문자열을 저장할 수 있는 자료형
    //변수 이름은 중복이 되면 안된다.
    //변수의 이름이 숫자로 시작해서는 안된다.
    //변수의 이름은 공백이 허용되지 않는다.
    //변수의 특수문자는 _와 $만 허용된다.

    //char value1 = 'A';
    //10은 10진수로 0~9
    //2진수 0또는 1만 표현할 수 있다.
    //사람이 사용하는 숫자를 전잘하게 되면 컴퓨터는 모든 것을 2진수로 받아들인다.
    
    //int value_2 = 10;
   // float value = 3.14f;


        
        /*
         * if(10==15)
        { 
            print("10과 10이 같습니다.");
        }
        else if(12==12)
        {
            print("12와 12가 같습니다.");
        }
        //print(value1);
        //print(value_2);
        //print(value);
        */
         //인스펙터 공개

    public GameObject prefab;
    //public : 스크립트 내부에 있는 변수의 내용이나 게임 오브젝트를 확인하거나 접근할 수 있다.
    //private : 스크립트 내부에 있는 변수의 내용이나 게임 오브젝트 공개하지 않도록 설정한다.

    public void GenericCreate()
    {
        //instantiate : 게임 오브젝트를 생성하는 함수
        Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);

    }

    public void PoolCreatre()
    {
        ObjectPool.objepool.GetQueue();
    }
}

