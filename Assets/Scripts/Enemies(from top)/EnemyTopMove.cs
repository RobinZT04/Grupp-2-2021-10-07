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
        // Hämtar componenten -Henry
        //rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // När enemyn träffar tagen "Barrier" förstörs objektet och respawnar -Henry
        if (collision.transform.tag == "Barrier")
        {
            Instantiate(enemytop, new Vector3(Random.Range(-12.5f, 12.5f), Random.Range(11, 20), 0), Quaternion.identity);
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // När enemyn blir träffad av "Bullet" förstörs objektet och respawnar -Henry
        if (collision.transform.tag == "Bullet")
        {
            Instantiate(enemytop, new Vector3(Random.Range(-12.5f, 12.5f), Random.Range(11, 20), 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Rör enemyn nedåt -Henry
        rb.velocity = new Vector2(0, enemyspeed);
    }
}
