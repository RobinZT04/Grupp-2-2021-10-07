using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//Made by José Luis
public class BossActivation : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider2D collision)
    {
        if(collision.CompareTag("Player")) // if the collision happen with something with the tag Player 
        {
            BossUI.instance.BossActivator();

           // StartCoroutine(WaitForBoss());
        }
    }
  

}
