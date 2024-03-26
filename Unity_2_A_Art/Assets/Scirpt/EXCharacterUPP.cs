using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXCharacterUPP : EXCharacter
{
    protected override void Move()
    {
        base.Move(); //base 키워드를 사용하여 기존 함수 동작 실행
        transform.Translate(
            Vector3.forward * speed * 2
            * Time.deltaTime);
    }
}
