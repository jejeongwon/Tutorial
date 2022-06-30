using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update

    bool condition = false; //참과 거짓을 저장하는 변수이다.
                    //0과 1만 들어간다.

    public float speed;

    Rigidbody rigid;
    Vector3 dir;


    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");

        //스페이스 바를 눌렀을때 && condition == true
        //&& 두개의 조건이 참이면 실행된다.
        //ll 한 개라도 참이면 실행된다.
        if (Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            //AddForce : 객체에 일정한 힘을 가하는 함수이다.
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }
    //FixedUpdate : 물리적인 연산을 수행할 때 호출되는 함수로 TimeStep에 설정된 값에 따라 일정한 주기로 호출되는 함수이다.
    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + dir.normalized * speed * Time.fixedDeltaTime);
    }


    //OnCollisionEnter : 게임 오브젝트가 물리적인 충돌이 되었을때 호출되는 함수이다.
    //OnCollisionStay : 게임 오브젝트가 물리적인 충돌을 하고 있을때 호출되는 함수이다.
    //OnCollisionExit : 게임 오브젝트가 물리적인 충돌을 벗어났을때 호출되는 함수이다.
    //리지드 바디가 호출되어야 한다.
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 중");
    }

    private void OnCollisionExit(Collision collision)
    {
        condition = false;
    }

    //OnTriggerEnte : 게임 오브젝트가 물리적인 충돌을 하지 않고 충돌했을때 호출되는 함수
    //OnTriggerStay : 게임 오브젝트가 물리적인 충돌을 하지 않고 충돌을 했을때 호출되는 함수
    //OnTriggerExit : 게임 오브젝트가 물리적인 충돌을 하지 않고 충돌을 벗어났을때 호출되는 함수
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger stay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }
}
