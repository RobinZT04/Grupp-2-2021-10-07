using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float Speed = 4.5f;

    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed; // this will make it move forwards durring the update method 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
