using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    int cont=0;
    public bool isPlayer=true;
    public float delay=0.5f;
    private void OnCollisionEnter2D(Collision2D other) {
        if (isPlayer) GameManager.singleton.score1++;
        else GameManager.singleton.score2++;
        UI_Manager.singleton.UpdateUI();
        cont++;
        Destroy(other.gameObject);
        if (cont > 3) cont = 3;
        for(int i=0; i < cont; i++){
            Invoke("Spawn", delay*cont);
        }
    }

    private void Spawn(){
        BallSpawner.singleton.SpawnBall();

    }
}
