using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Everything here is made by José Luis
public class BossBehaviour : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints;
    public HealthbarBehaviour Healthbar;

    // Start is called before the first frame update
    void Start()
    {
        MaxHitpoints = 20;
        Hitpoints = MaxHitpoints; // when Boss spawns we will like reset it's health to be maxhealth
        //Healthbar.SetHealth(Hitpoints, MaxHitpoints); // 
    }

    /*public void TakeHit(float damage)
     {
         Hitpoints -= damage; // subtract their health when they get hit 
         Healthbar.SetHealth(Hitpoints, MaxHitpoints);

         if (Hitpoints <= 0) // and when they have no more hit points
         {
             Destroy(gameObject); // Destroy the gameobejct so despawn them with the destroy function 
         }
     }*/

    public void Update()
    {
        Healthbar.slider.value = Hitpoints;
        Healthbar.slider.maxValue = MaxHitpoints;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            Hitpoints -= 1; // subtract their health when they get hit 
            //Healthbar.SetHealth(Hitpoints, MaxHitpoints);

            if (Hitpoints <= 0) // and when they have no more hit points
            {
                Destroy(gameObject); // Destroy the gameobejct so despawn them with the destroy function 
            }
        }
    }

}
