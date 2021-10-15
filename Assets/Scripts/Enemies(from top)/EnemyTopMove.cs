using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTopMove : MonoBehaviour
{
    // Referens till rigidbodyn -Henry
    public Rigidbody2D rb;

    // Referens till enemyns snabbhet -Henry
    private float enemyspeed = -3.75f;

    // Referens till enemyn -Henry
    public GameObject enemytop;

    // Start is called before the first frame update
    void Start()
    {
        // H�mtar componenten -Henry
        //rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // N�r enemyn tr�ffar tagen "Barrier" f�rst�rs objektet och respawnar -Henry
        if (collision.transform.tag == "Barrier")
        {
            Instantiate(enemytop, new Vector3(Random.Range(-12.5f, 12.5f), Random.Range(11, 20), 0), Quaternion.identity);
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // N�r enemyn blir tr�ffad av "Bullet" f�rst�rs objektet och respawnar -Henry
        if (collision.transform.tag == "Bullet")
        {
            Instantiate(enemytop, new Vector3(Random.Range(-12.5f, 12.5f), Random.Range(11, 20), 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // R�r enemyn ned�t -Henry
        rb.velocity = new Vector2(0, enemyspeed);
    }
}
