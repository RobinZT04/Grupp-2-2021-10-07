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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canstart)
        {
            Instantiate(box,(spawnpoint),Quaternion.identity);
        }
    }
}
