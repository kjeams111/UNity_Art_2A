using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ExGamedata", fileName = "New ExGamedata ", order = 50)]
public class ExGamedata : ScriptableObject
{
    public string gameName;
    public int gameScore;
    public bool isGameActive;
}
