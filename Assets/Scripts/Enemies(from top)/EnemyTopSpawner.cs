using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTopSpawner : MonoBehaviour
{
    // Referens till enemyn -Henry
    public GameObject enemytop;

    // Start is called before the first frame update
    void Start()
    {
        // Upprepar koden 6 ggr -Henry
        for (int i = 0; i < 6; i++)
        {
            // Klonar enemytop till ett random ställe i x-axeln -Henry
            Instantiate(enemytop, new Vector3(Random.Range(-12.5f, 12.5f), Random.Range(11, 20), 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
