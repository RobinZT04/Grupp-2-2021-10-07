using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject restart; //referens till restart knappen  - Robin
    public GameObject restartdetails; //referens till restart sprites - Robin
    public GameObject gun; //referens till pistolen  - Robin

    public Animator player; //referens till player animator  - Robin

    public bool dead; //variabel bool som kollar om spelaren är död  - Robin

    public GameObject boss; //referens till bossen  - Robin

    public bool bossspawn; //variabel som frågar om bossen har spawnat  - Robin


    public void Start()
    {
        EnemyTopCounter.EnemyCounter = 0;
        dead = false; //sätter att spelaren inte är död  - Robin
        bossspawn = false; //sätt bosspawn till faslse  - Robin
    }
    public void Update()
    {
        if (!bossspawn) //om bossen inte har spawnat - Robin
        {
            if (EnemyTopCounter.EnemyCounter >= 40) //om enemy counter är högre än 5  - Robin
            {
                boss.SetActive(true); //sätt igång bossen - Robin
                bossspawn = true; //sätt boss spawn till true - Robin
            }
        }

        if (barrier.hp <= 0)
        {
            restart.SetActive(true); //sätter på restart knappen  - Robin
            restartdetails.SetActive(true); //sätter på restart sprites  - Robin
            player.SetBool("Dead", true); //sätter player animationen dead till true  - Robin
            gun.SetActive(false); //tänger av pistolen  - Robin
            dead = true; //sätter spelaren till död - Robin
        }
        if (!dead) //om spelaren är död  - Robin
        {
            //Time.timeScale = 1;
            IWalk walker = GetComponent(typeof(IWalk)) as IWalk; //säger att Iwalk interfacen är "walker" - Robin
        walker.Walking(); //startar funktionen Walking i IWalk - Robin

        IShoot shooter = GetComponent(typeof(IShoot)) as IShoot; //säger att Iwalk interfacen är "Shooting" - Robin
        shooter.Shooting(); //startar funktionen Walking i IShoot- Robin

        IDash dasher = GetComponent(typeof(IDash)) as IDash; //säger att Iwalk interfacen är "Shooting" - Robin
        dasher.Dashing(); //startar funktionen Walking i IShoot- Robin
        }

    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.transform.tag == "Barrel") //om du collidaer med Barrel  - Robin
        {
            restart.SetActive(true); //sätter på restart knappen  - Robin
            restartdetails.SetActive(true); //sätter på restart sprites  - Robin
            player.SetBool("Dead", true); //sätter player animationen dead till true  - Robin
            gun.SetActive(false); //tänger av pistolen  - Robin
            dead = true; //sätter spelaren till död - Robin
        }
        if(other.transform.tag == "BossBullet") // om du collidar med bossbullet  - Robin
        {
            restart.SetActive(true); //sätter på restart knappen  - Robin
            restartdetails.SetActive(true); //sätter på restart sprites  - Robin
            player.SetBool("Dead", true); //sätter player animationen dead till true  - Robin
            gun.SetActive(false); //tänger av pistolen  - Robin
            dead = true; //sätter spelaren till död - Robin
        }

    }
}
