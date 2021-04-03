using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score1=0;
    public int score2=0;
    public int max_de_bola=5;
    public static GameManager singleton;


    private void Awake() {
        singleton = this;
    }
      
}
