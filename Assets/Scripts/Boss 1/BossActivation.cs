using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivation : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider2D collision)
    {
        if(collision.CompareTag("Player")) // if the collision happen with something with the tag Player 
        {
            BossUI.instance.BossActivator();
            StartCoroutine(WaitForBoss());
        }
    }
    IEnumerator WaitForBoss()
    {
        var currentSpeed = PlayerController.instance.speed; // we will save our speed that we have on currentSpeed
        PlayerController.instance.speed = 0; // we will change it to 0 
        yield return new WaitForSeconds(3); // and after 3 seconds 
        PlayerController.instance.speed = currentSpeed; // the 0 will go back to the ccurrentSpeed
    }

}
