using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingScript : MonoBehaviour, IShoot
{
    public GameObject bullet; //referens till bullet prefab - Robin

    public GameObject player; //referens till player gameobjectet - Robin

    public Transform bulletpoint; //refrens till bulletpoint position - Robin

    public Rigidbody2D body; //en referens till rigidbody2D:n - Robin

    public bool recoil; //variabel bool till recoil - Robin

    [Range(200f, 10000f)]  //gör en "slider" i inspectorn vilket gör det lättare att justera styrkan av recoilen - Robin

    public float recoilforce; //hur stark är recoilen? - Robin
    public float ammo = 1; //en variabel som räknar antalet ammo du har - Robin

    public Animator gunanim;

    public void Shooting() //funktion som tar hand om Shooting - Robin
    {
            if(Input.GetKeyDown(KeyCode.Space) && ammo >= 1)//om spelaren håller ned vänster klick på musen eller space knappen på tangenbordet - Robin
            {
                Instantiate(bullet, new Vector3(bulletpoint.position.x, bulletpoint.position.y + 0.3f, bulletpoint.position.z), Quaternion.identity); //spawnar skottet på bulletpoints position - Robin
                ammo -= 1; //säger att spelaren har skjutit ett skott - Robin
                recoil = true; //sätter recoil till true - Robin
                player.transform.localScale = new Vector2(1.1f, 0.8f);
            gunanim.SetBool("spin", true);
                StartCoroutine(Reload()); //startar den funktionen Reload som är en coroutine - Robin
            }



        if (recoil) //om recoil är true - Robin
        {
            body.AddForce(-transform.up * 8000 * Time.deltaTime); //börja röra spelaren nedåt med velocityn 5000 - Robin
            StartCoroutine(Recoil()); //startar en coroutine - Robin
        }


        IEnumerator Recoil() //funktionen till coroutinen - Robin
        {
            yield return new WaitForSeconds(0.2f); //väntar i 0.2 sekunder - Robin
            recoil = false; //sätter recoil till false - Robin
        }
        IEnumerator Reload() //funktionen till coroutinen - Robin
        {
            yield return new WaitForSeconds(0.15f); //väntar i 1 sekunder - Robin
            player.transform.localScale = new Vector2(1, 1f);
            yield return new WaitForSeconds(0.2f); //väntar i 1 sekunder - Robin
            gunanim.SetBool("spin", false);
            yield return new WaitForSeconds(0.5f); //väntar i 1 sekunder - Robin
            ammo = 1; //sätter ammo till 1 - Robin
        }
    }
}
