using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacterManager : MonoBehaviour
{
    public List<EXCharacter> characterList = new List<EXCharacter>();
    //���� ���� Ŭ������ ����ص� excharacterfast,chracterup �ڽ� Ŭ������ list�� �������

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //Ű�� ������ �ı� �ȴ�
        {
            for(int i = 0; i < characterList.Count; i++)
            {
                characterList[i].DestoryCharacter();
            }
        }
        
    }
}
