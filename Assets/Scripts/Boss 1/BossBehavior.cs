using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBehavior : MonoBehaviour
{
    public Transform[] transforms;

    public GameObject flame;

    public float timeToShoot, countdown;

    public float bossHealth, currentHealth;

    public Image healthImg;


    private void Start()
    {
        var initialPosition = Random.Range(0, transforms.Length); // the number that we get randomly 
        transform.position = transforms[initialPosition].position; // will be added to our array and will be teleported to them randomly.
        countdown = timeToShoot;
    }


    private void Update()
    {
        Countdowns();
        DamageBoss();
    }

    public void Countdowns()
    {
        countdown -= Time.deltaTime; // 

        if (countdown < 0) // if countdown if less then 0 
        {
            ShootPlayer();
            countdown = timeToShoot; // we shoot and restart to 3sec
            Teleport();
        }
    }

     public void ShootPlayer()
    {
        
            GameObject spell = Instantiate(flame, transform.position, Quaternion.identity); // 
    }

    public void Teleport()
    {
        var initialPosition = Random.Range(0, transforms.Length); // the number that we get randomly 
        transform.position = transforms[initialPosition].position; // will be added to our array and will be teleported to them randomly.
    }

    public void DamageBoss()
    {
        currentHealth = GetComponent<Boss>().healthPoints;
        healthImg.fillAmount = currentHealth / bossHealth; 
    }

}

    

