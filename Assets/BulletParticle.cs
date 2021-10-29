using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticle : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public GameObject spark;

    List<ParticleCollisionEvent> colEvents = new List<ParticleCollisionEvent>();
    private int i;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            particleSystem.Play();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
       int events =  particleSystem.GetCollisionEvents(other, colEvents);

        

        for (int i = 0; i < events;) i++;
        {
            Instantiate(spark, colEvents[i].intersection, Quaternion.LookRotation(colEvents[i].normal));
        }
    }


}
