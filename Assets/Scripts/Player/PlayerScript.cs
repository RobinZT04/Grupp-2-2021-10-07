using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject restart;
    public GameObject restartdetails;
    public Animator player;
    public void Update()
    {
        Time.timeScale = 1;
        IWalk walker = GetComponent(typeof(IWalk)) as IWalk; //säger att Iwalk interfacen är "walker" - Robin
        walker.Walking(); //startar funktionen Walking i IWalk - Robin

        IShoot shooter = GetComponent(typeof(IShoot)) as IShoot; //säger att Iwalk interfacen är "Shooting" - Robin
        shooter.Shooting(); //startar funktionen Walking i IShoot- Robin

        IDash dasher = GetComponent(typeof(IDash)) as IDash; //säger att Iwalk interfacen är "Shooting" - Robin
        dasher.Dashing(); //startar funktionen Walking i IShoot- Robin

        IGrenade grenader = GetComponent(typeof(IGrenade)) as IGrenade;
        grenader.Throwing();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Barrel")
        {
            restart.SetActive(true);
            restartdetails.SetActive(true);
            player.SetBool("Dead", true);
        }
    }
}
