using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PadMoviment
{
    // Update is called once per frame
    void Update(){
        float Vertical = Input.GetAxis("Vertical"); //pegar input vertical do teclado
        Move(Vertical);
    }
}
