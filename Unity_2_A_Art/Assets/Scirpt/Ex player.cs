using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explayer : MonoBehaviour
{
    private int health = 100; //플레이어 체력
    //플레이어가 피해를 받을 때 호추로디는 메서스
    public void TakeDamage(int damage)
    {
        //플레이어의 체력 감소
        health -= damage;
        Debug.Log("플레이어 피격.남은 체력 :" + health);

        //체력이 0 이하로 떨어졌을 때 플레이어 사망처리
        if (health <= 0)
        {
            Die();
        }

    }
    private void Die()
    {
        Debug.Log("플레이어가 사망했습니다.");
        //사망 처리 로직 추가
    }
}
