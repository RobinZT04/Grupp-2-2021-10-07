using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesFromTop : MonoBehaviour
{
    // Referens till enemyn -Henry
    public GameObject enemytop;

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

        for (int i = 0; i < 10; i++)
        {
            //Instantiate(enemytop, new Vector3(Random.Range(0, 5.5), transform.position.y, Quaternion.identity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
