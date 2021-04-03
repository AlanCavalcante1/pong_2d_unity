using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : PadMoviment
{
    GameObject[] bolas;
    
    void Update()
    {
        bolas = GameObject.FindGameObjectsWithTag("Bola");
        Transform target = FindBall(bolas);
        if (target == null) return;
        if (transform.position.y > target.position.y) Move(-1);
        else Move(1);
    }

    Transform FindBall(GameObject[] bola){
        Transform result = null;
        float record = -1;
        foreach(GameObject obj in bola){
            float distance = Vector2.Distance(transform.position, obj.transform.position);
           if (distance < record || record == -1){
               record = distance;
               result = obj.transform;
           }
        }
        return result;
    }
}
