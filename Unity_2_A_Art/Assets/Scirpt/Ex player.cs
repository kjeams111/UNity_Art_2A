using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explayer : MonoBehaviour
{
    private int health = 100; //�÷��̾� ü��
    //�÷��̾ ���ظ� ���� �� ȣ�߷ε�� �޼���
    public void TakeDamage(int damage)
    {
        //�÷��̾��� ü�� ����
        health -= damage;
        Debug.Log("�÷��̾� �ǰ�.���� ü�� :" + health);

        //ü���� 0 ���Ϸ� �������� �� �÷��̾� ���ó��
        if (health <= 0)
        {
            Die();
        }

    }
    private void Die()
    {
        Debug.Log("�÷��̾ ����߽��ϴ�.");
        //��� ó�� ���� �߰�
    }
}
