using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTopMove : MonoBehaviour
{
    // Referens till rigidbodyn -Henry
    Rigidbody2D rb;

    // Referens till enemyns snabbhet -Henry
    private int enemyspeed = -3;

    // Start is called before the first frame update
    void Start()
    {
        // Hämtar componenten och rör enemyn nedåt -Henry
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, enemyspeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
