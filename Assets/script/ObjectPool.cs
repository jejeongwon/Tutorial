using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // Start is called before the first frame update
    //자료구조
    //Queue : 가장 먼저 들어온 데이터가 가장 먼저 나가는 구조이다.
    //static : 게임이 종료될때까지 메모리에 남아 있다.
   
    public static ObjectPool objepool;
    
    public GameObject prefab;
   
    public Queue<GameObject> queue = new Queue<GameObject>();


    private void Start()
    {
        objepool = this;

        //1. 초기값을 설정한다.
        //2. 조건식을 설정한다.
        //3. 명령문을 한번 실행한다.
        //4. 초기값을 증감시킨다.
        for(int i = 0; i < 5; i++)
        {
           GameObject tempPrefab = Instantiate(prefab, new Vector3(0, 5, 0), (Quaternion.identity));
            queue.Enqueue(tempPrefab);
            tempPrefab.SetActive(false);
        }
    }

    public void InsertQueue(GameObject tObject)
    {
        queue.Enqueue(tObject);
        tObject.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject tempObject = queue.Dequeue();
        tempObject.SetActive(true);

        return tempObject;
    }
}
