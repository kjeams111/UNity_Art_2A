using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXCharacter : MonoBehaviour
{

    public float speed = 5f; // 캐릭터 이동 속도
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(); // 프레임마다 Move 함수 호출
    }

    protected virtual void Move() //virtual 키워드를 작성하여 상속 받은 클래스가 재 정의 할 수 있게 한다.
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); //캐릭터를 앞으로 이동
    }

     public void DestoryCharacter() //캐릭터 파괴
    {
        Destroy(gameObject);
    }
}
