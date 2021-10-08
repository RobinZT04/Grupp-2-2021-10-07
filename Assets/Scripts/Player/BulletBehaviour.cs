using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [Range(200f, 3000f)] //gör en "slider" i inspectorn vilket gör det lättare att justera fart till spelaren - Robin
    public float speed; //variabel till speed - Robin
    public Rigidbody2D bulletrgb; //referens till bullets rigidbody - Robin
    void Update()
    {
        bulletrgb.velocity = transform.up * speed * Time.deltaTime; //sätter bullets velocity att röra sig uppåt - Robin
    }
}
