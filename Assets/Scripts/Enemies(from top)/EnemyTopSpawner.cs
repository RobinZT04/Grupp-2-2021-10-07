using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTopSpawner : MonoBehaviour
{
    // Referens till enemyn -Henry
    public GameObject enemytop;

    public GameObject boss;
    public bool spawned;

    // Start is called before the first frame update
    void Start()
    {
        // Upprepar koden 3 ggr -Henry
        for (int i = 0; i < 3; i++)
        {
            print("New enemy");
            // Klonar enemytop till ett random st?lle i x-axeln -Henry
            Instantiate(enemytop, new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(9, 15), 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyTopCounter.EnemyCounter >= 40) 
        {

            if (!spawned) 
            {
                boss.SetActive(true);
                spawned = true;
            }
        }
    }
}