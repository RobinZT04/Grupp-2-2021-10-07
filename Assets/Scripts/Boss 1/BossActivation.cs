using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//Made by José Luis
public class BossActivation : MonoBehaviour
{

    public GameObject bossGO;

    private void Start()
    {
        bossGO.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) // if the collision happen with something with the tag Player 
        {
            BossUI.instance.BossActivator();

            StartCoroutine(WaitForBoss());
            
        }  
    }
    IEnumerator WaitForBoss()
    {
        var currentSpeed = PlayerController.instance.moveSpeed; // we will save the speed that we have on currentspeed 
        PlayerController.instance.moveSpeed = 0; // we will change it to 0
        bossGO.SetActive(true);
        yield return new WaitForSeconds(4f);// and fter the 4 second passes
        PlayerController.instance.moveSpeed = currentSpeed; // the 0 we got will change to it's currentspeed
        Destroy(gameObject); // the moment we tuch it will destroy
    }

}
