using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints;
    public HealthbarBehaviour Healthbar;

    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints; // when Boss spawns we will like reset it's health to be maxhealth
        Healthbar.SetHealth(Hitpoints, MaxHitpoints); // 
    }

   public void TakeHit(float damage)
    {
        Hitpoints -= damage; // subtract their health when they get hit 
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);

        if (Hitpoints <= 0) // and when they have no more hit points
        {
            Destroy(gameObject); // Destroy the gameobejct so despawn them with the destroy function 
        }
    }
    
}
