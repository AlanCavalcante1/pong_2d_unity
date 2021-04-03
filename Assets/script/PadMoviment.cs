using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//extend = :
public class PadMoviment : MonoBehaviour
{
    Rigidbody2D rigidbody2d; 
    public float speed=5;
    Vector2 eixo_y = new Vector2(0, 1); //eixo_y = [0,1]
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    protected void Move(float V = 0){
        rigidbody2d.velocity = Vector2.zero; //velocidade = 0
        rigidbody2d.AddForce(eixo_y * V * speed);
    }

}
