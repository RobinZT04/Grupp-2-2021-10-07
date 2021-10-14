using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemieside : MonoBehaviour
{
    public float position;
    public GameObject box;

    public Transform box1;
    public Transform box2;
    public Transform box3;
    public Transform box4;

    public Vector2 spawnpoint;

    public bool canstart;
    void Start()
    {
        position = Random.Range(1, 4);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(position == 1)
        {
            spawnpoint = box1.position;
        }
        if (position == 2)
        {
            spawnpoint = box2.position;
        }
        if (position == 3)
        {
            spawnpoint = box3.position;
        }
        if (position == 4)
        {
            spawnpoint = box4.position;
        }

        if (canstart)
        {
            Instantiate(box, (spawnpoint), Quaternion.identity);
            canstart = false;
        }
    }
}
