using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exenemy : MonoBehaviour
{
    private int damage = 20;
    public Explayer Targetplayer;
    public void AttcakPlayer(Explayer player)
    {
        //�÷��̾�� ���ظ� �ش�.
        player.TakeDamage(damage);
        Debug.Log("�÷��̾� ����.");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AttcakPlayer(Targetplayer);
        }
    }
}
