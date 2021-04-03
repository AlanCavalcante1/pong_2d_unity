using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 direcao = new Vector2(1, 1); //direcao inicial
    Rigidbody2D rigidbody2d; 
    public float speed = 10;
    public float aumento = 1.1f;
    public static int qtd_de_bola = 0;
    // Start is called before the first frame update
    void Start()
    {
        qtd_de_bola++;
        if (qtd_de_bola > GameManager.singleton.max_de_bola){
            Destroy(gameObject);
            return;
        }
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2d.velocity = Vector2.zero; //velocidade = 0
        rigidbody2d.AddForce(direcao * speed);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        speed *= aumento;
        direcao = Vector2.Reflect(direcao, other.GetContact(0).normal);
    }

    private void OnDestroy() {
        qtd_de_bola--;
    }
}
