using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Made by José Luis
public class BossMovment : MonoBehaviour
{
    float speed;
    Rigidbody2D rb;

    

    // Start is called before the first frame update
    void Start()
    {
        speed = GetComponent<Boss>().speed; // our speed that i wrote on the Boss script = 
        rb = GetComponent<Rigidbody2D>();
    }

   

   
}
