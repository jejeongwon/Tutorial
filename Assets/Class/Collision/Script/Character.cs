using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update

    bool condition = false; //���� ������ �����ϴ� �����̴�.
                    //0�� 1�� ����.

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

        //�����̽� �ٸ� �������� && condition == true
        //&& �ΰ��� ������ ���̸� ����ȴ�.
        //ll �� ���� ���̸� ����ȴ�.
        if (Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            //AddForce : ��ü�� ������ ���� ���ϴ� �Լ��̴�.
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }
    //FixedUpdate : �������� ������ ������ �� ȣ��Ǵ� �Լ��� TimeStep�� ������ ���� ���� ������ �ֱ�� ȣ��Ǵ� �Լ��̴�.
    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + dir.normalized * speed * Time.fixedDeltaTime);
    }


    //OnCollisionEnter : ���� ������Ʈ�� �������� �浹�� �Ǿ����� ȣ��Ǵ� �Լ��̴�.
    //OnCollisionStay : ���� ������Ʈ�� �������� �浹�� �ϰ� ������ ȣ��Ǵ� �Լ��̴�.
    //OnCollisionExit : ���� ������Ʈ�� �������� �浹�� ������� ȣ��Ǵ� �Լ��̴�.
    //������ �ٵ� ȣ��Ǿ�� �Ѵ�.
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹 ��");
    }

    private void OnCollisionExit(Collision collision)
    {
        condition = false;
    }

    //OnTriggerEnte : ���� ������Ʈ�� �������� �浹�� ���� �ʰ� �浹������ ȣ��Ǵ� �Լ�
    //OnTriggerStay : ���� ������Ʈ�� �������� �浹�� ���� �ʰ� �浹�� ������ ȣ��Ǵ� �Լ�
    //OnTriggerExit : ���� ������Ʈ�� �������� �浹�� ���� �ʰ� �浹�� ������� ȣ��Ǵ� �Լ�
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
