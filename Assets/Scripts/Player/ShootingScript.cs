using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingScript : MonoBehaviour, IShoot
{

    public GameObject bulletparticle; //referens till bullet particle

    public GameObject bullet; //referens till bullet prefab - Robin

    public GameObject player; //referens till player gameobjectet - Robin

    public GameObject particles; //referens till particles gameobject - Robin

    public Transform bulletpoint; //refrens till bulletpoint position - Robin

    public Rigidbody2D body; //en referens till rigidbody2D:n - Robin

    public bool recoil; //variabel bool till recoil - Robin

    [Range(200f, 10000f)]  //gör en "slider" i inspectorn vilket gör det lättare att justera styrkan av recoilen - Robin

    public float recoilforce; //hur stark är recoilen? - Robin
    public float ammo = 1; //en variabel som räknar antalet ammo du har - Robin

    public Animator gunanim; //referens till gun animator - Robin

    public Animator playeranim; //referens till player animator - Robin

    public void Shooting() //funktion som tar hand om Shooting - Robin
    {
            if(Input.GetKey(KeyCode.Space) && ammo >= 1)//om spelaren håller ned vänster klick på musen eller space knappen på tangenbordet - Robin
            {
                Instantiate(bullet, new Vector3(bulletpoint.position.x, bulletpoint.position.y + 0.3f, bulletpoint.position.z), Quaternion.identity); //spawnar skottet på bulletpoints position - Robin
                ammo -= 1; //säger att spelaren har skjutit ett skott - Robin
                recoil = true; //sätter recoil till true - Robin
                player.transform.localScale += new Vector3(1f, 0.8f,0); //ökar spelarens scale - Robin
                playeranim.SetBool("shoot", true); //säter skjut animationen till true - Robin
                particles.SetActive(true); //sätter på partiklarna - Robin
                gunanim.SetBool("Shooting", true);
                 Instantiate(bulletparticle, new Vector3(player.transform.position.x + 0.5f, player.transform.position.y + 0.3f, 0), Quaternion.identity); //spawnar skottet - Robin
                StartCoroutine(Reload()); //startar den funktionen Reload som är en coroutine - Robin
            }



        if (recoil) //om recoil är true - Robin
        {
            CameraShake.shaking = true; //sätter på camerashake
            body.AddForce(-transform.up * 8000 * Time.deltaTime); //börja röra spelaren nedåt med velocityn 5000 - Robin
            StartCoroutine(Recoil()); //startar en coroutine - Robin
        }


        IEnumerator Recoil() //funktionen till coroutinen - Robin
        {
            yield return new WaitForSeconds(0.2f); //väntar i 0.2 sekunder - Robin       
            recoil = false; //sätter recoil till false - Robin
            CameraShake.shaking = false; //stänger av camera shake
            
        }
        IEnumerator Reload() //funktionen till coroutinen - Robin
        {
            yield return new WaitForSeconds(0.5f); //väntar i 0.15 sekunder - Robin
            gunanim.SetBool("spin", true); //sätter snurr animationen till true - Robin
            player.transform.localScale = new Vector2(1, 1f); //gör gubben till normal skala - Robin
            gunanim.SetBool("Shooting", false); //stänger av skjut animation - Robin
            playeranim.SetBool("shoot", false); //stänger av snurr animationen på pistolen
            yield return new WaitForSeconds(0.3f); //väntar i 0.2 sekunder - Robin

            gunanim.SetBool("spin", false); //aktiverar snurr animationen på pistolen - Robin
            yield return new WaitForSeconds(0.2f); //väntar i 0.2 sekunder - Robin
            particles.SetActive(false); //stänger av partiklarna - Robin
            ammo = 1; //sätter ammo till 1 - Robin
        }
    }
}
