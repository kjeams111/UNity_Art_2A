using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExparentClass : MonoBehaviour
{
    //protected�� ����� ������ ���� Ŭ���� �� �Ļ� Ŭ�������� ���ٰ��� 
    protected int protectedValue;
} 
public class ExChildclass : ExparentClass
{
    void Start()
    {
        //ExParentClass�� ProTected ������ ���� ����
        Debug.Log("Protected value from child Claas : " + protectedValue);
    }
}

