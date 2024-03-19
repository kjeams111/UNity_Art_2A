using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExGameManager : MonoBehaviour
{
    public ExGamedata gamedata;
    void Start()
    {
        Debug.Log("Game Name :" + gamedata.gameName);
        Debug.Log("Game Score :" + gamedata.gameScore);
        Debug.Log("Game Is Game Active :" + gamedata.isGameActive);


    }
}
