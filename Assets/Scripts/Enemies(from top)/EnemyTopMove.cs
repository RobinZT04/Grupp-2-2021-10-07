using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTopMove : MonoBehaviour
{
    // Referens till rigidbodyn -Henry
    public Rigidbody2D rb;

    // Referens till enemyns snabbhet -Henry
    private float speed;

    // Referens till enemyn -Henry
    public GameObject enemytop;

    // Referens till blodeffekten; -Henry
    public GameObject bloodEffect;

    //public GameObject boss;

    // Start is called before the first frame update
    void Start()
    {
        // Variabeln speed f�r en random hastighet mellan v�rderna n�r spelet startar
        speed = Random.Range(-1.75f, -2.5f);

        // R�r enemyn ned�t -Henry
        rb.velocity = new Vector2(0, Random.Range(-2, -50));

        // H�mtar componenten -Henry
        //rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // N�r enemyn tr�ffar tagen "Barrier" f�rst�rs objektet, spelar blod-animationen och respawnar objektet -Henry
        if (collision.transform.tag == "Barrier")
        {
            if (EnemyTopCounter.EnemyCounter <= 40)
            {
                Instantiate(enemytop, new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(9, 15), 0), Quaternion.identity);
                print("Enemy hit by wall");
            }
            Instantiate(bloodEffect, transform.position, Quaternion.identity);
            EnemyTopCounter.EnemyCounter += 1;
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // N�r enemyn blir tr�ffad av "Bullet" f�rst�rs objektet, spelar blod-animationen och respawnar objektet -Henry
        if (collision.transform.tag == "Bullet")
        {
            if (EnemyTopCounter.EnemyCounter <= 40)
            {
                print("Enemy hit by bullet");
                Instantiate(enemytop, new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(9, 15), 0), Quaternion.identity);
            }
            Instantiate(bloodEffect,transform.position, Quaternion.identity);
            EnemyTopCounter.EnemyCounter += 1;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(EnemyTopCounter.EnemyCounter);
        // Ger enemyn hastigheten som finns i variabeln "speed" -Henry
        rb.velocity = new Vector2(0, speed);
        if (EnemyTopCounter.EnemyCounter >= 40)
        {
            //boss.SetActive(true);
            Destroy(gameObject);
        }
    }
}
