using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Update is called once per frame

    public void Update()
    {
        Time.timeScale = 1;
        IWalk walker = GetComponent(typeof(IWalk)) as IWalk; //s�ger att Iwalk interfacen �r "walker" - Robin
        walker.Walking(); //startar funktionen Walking i IWalk - Robin

        IShoot shooter = GetComponent(typeof(IShoot)) as IShoot; //s�ger att Iwalk interfacen �r "Shooting" - Robin
        shooter.Shooting(); //startar funktionen Walking i IShoot- Robin
    }
}