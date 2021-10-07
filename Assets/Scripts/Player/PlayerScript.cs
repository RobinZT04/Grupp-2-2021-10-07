using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public void Update()
    {
        IWalk walker = GetComponent(typeof(IWalk)) as IWalk; //säger att Iwalk interfacen är "walker" - Robin
        walker.Walking(); //startar funktionen Walking i IWalk - Robin

        IShoot shooter = GetComponent(typeof(IShoot)) as IShoot; //säger att Iwalk interfacen är "Shooting" - Robin
        shooter.Shooting(); //startar funktionen Walking i IShoot- Robin
    }
}
