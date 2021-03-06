using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject restart; //referens till restart knappen  - Robin
    public GameObject restartdetails; //referens till restart sprites - Robin
    public GameObject gun; //referens till pistolen  - Robin

    public Animator player; //referens till player animator  - Robin

    public bool dead; //variabel bool som kollar om spelaren ?r d?d  - Robin

    public GameObject boss; //referens till bossen  - Robin

    public bool bossspawn; //variabel som fr?gar om bossen har spawnat  - Robin


    public void Start()
    {
        EnemyTopCounter.EnemyCounter = 0;
        dead = false; //s?tter att spelaren inte ?r d?d  - Robin
        bossspawn = false; //s?tt bosspawn till faslse  - Robin
    }
    public void Update()
    {
        if (!bossspawn) //om bossen inte har spawnat - Robin
        {
            if (EnemyTopCounter.EnemyCounter >= 40) //om enemy counter ?r h?gre ?n 5  - Robin
            {
                boss.SetActive(true); //s?tt ig?ng bossen - Robin
                bossspawn = true; //s?tt boss spawn till true - Robin
            }
        }

        if (barrier.hp <= 0)
        {
            restart.SetActive(true); //s?tter p? restart knappen  - Robin
            restartdetails.SetActive(true); //s?tter p? restart sprites  - Robin
            player.SetBool("Dead", true); //s?tter player animationen dead till true  - Robin
            gun.SetActive(false); //t?nger av pistolen  - Robin
            dead = true; //s?tter spelaren till d?d - Robin
        }
        if (!dead) //om spelaren ?r d?d  - Robin
        {
            //Time.timeScale = 1;
            IWalk walker = GetComponent(typeof(IWalk)) as IWalk; //s?ger att Iwalk interfacen ?r "walker" - Robin
        walker.Walking(); //startar funktionen Walking i IWalk - Robin

        IShoot shooter = GetComponent(typeof(IShoot)) as IShoot; //s?ger att Iwalk interfacen ?r "Shooting" - Robin
        shooter.Shooting(); //startar funktionen Walking i IShoot- Robin

        IDash dasher = GetComponent(typeof(IDash)) as IDash; //s?ger att Iwalk interfacen ?r "Shooting" - Robin
        dasher.Dashing(); //startar funktionen Walking i IShoot- Robin
        }

    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.transform.tag == "Barrel") //om du collidaer med Barrel  - Robin
        {
            restart.SetActive(true); //s?tter p? restart knappen  - Robin
            restartdetails.SetActive(true); //s?tter p? restart sprites  - Robin
            player.SetBool("Dead", true); //s?tter player animationen dead till true  - Robin
            gun.SetActive(false); //t?nger av pistolen  - Robin
            dead = true; //s?tter spelaren till d?d - Robin
        }
        if(other.transform.tag == "BossBullet") // om du collidar med bossbullet  - Robin
        {
            restart.SetActive(true); //s?tter p? restart knappen  - Robin
            restartdetails.SetActive(true); //s?tter p? restart sprites  - Robin
            player.SetBool("Dead", true); //s?tter player animationen dead till true  - Robin
            gun.SetActive(false); //t?nger av pistolen  - Robin
            dead = true; //s?tter spelaren till d?d - Robin
        }

    }
}
