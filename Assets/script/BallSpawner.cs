using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    public static BallSpawner singleton;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
        singleton = this;
    }

    public void SpawnBall(){
        GameObject.Instantiate(ball, transform.position, Quaternion.identity);
    }

}
