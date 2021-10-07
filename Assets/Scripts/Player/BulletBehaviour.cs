using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [Range(200f, 1500f)] //g�r en "slider" i inspectorn vilket g�r det l�ttare att justera fart till spelaren - Robin
    public float speed; //variabel till speed - Robin
    public Rigidbody2D bulletrgb; //referens till bullets rigidbody - Robin
    void Update()
    {
        bulletrgb.velocity = transform.up * speed * Time.deltaTime; //s�tter bullets velocity att r�ra sig upp�t - Robin
    }
}
