using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exenemy : MonoBehaviour
{
    private int damage = 20;
    public Explayer Targetplayer;
    public void AttcakPlayer(Explayer player)
    {
        //플레이어에게 피해를 준다.
        player.TakeDamage(damage);
        Debug.Log("플레이어 공격.");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AttcakPlayer(Targetplayer);
        }
    }
}
