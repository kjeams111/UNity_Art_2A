using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacterFast : EXCharacter
{

    //override Ű���带 ����Ͽ� �Լ� �ٽ� ����
  protected override void Move()
  {
        transform.Translate(
            Vector3.forward * speed * 2
            * Time.deltaTime);
  }
}
