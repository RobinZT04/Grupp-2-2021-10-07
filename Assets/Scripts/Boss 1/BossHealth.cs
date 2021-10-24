using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    Boss boss;

    private void Start()
    {
        boss = GetComponent<Boss>(); // will be the same as the component Boss which has the gameobject
    }

    private void OnTriggerEnter2D(Collider2D collision) // if this element does collision with another elemt that has trigger
    {
        if (collision.CompareTag("bullet")) // if the collision has caomparetag bullet 
        {
            boss.healthPoints -= 2f; // will hit healthpoints and we -= 2 points of health 

            if(boss.healthPoints <= 0) // if the points of health are <=  to 0 
            {
                Destroy(gameObject);
            }
        }
    }


}
