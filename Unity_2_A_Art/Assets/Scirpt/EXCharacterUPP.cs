using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXCharacterUPP : EXCharacter
{
    protected override void Move()
    {
        base.Move(); //base Ű���带 ����Ͽ� ���� �Լ� ���� ����
        transform.Translate(
            Vector3.forward * speed * 2
            * Time.deltaTime);
    }
}
