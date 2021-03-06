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

    [Range(200f, 10000f)]  //g?r en "slider" i inspectorn vilket g?r det l?ttare att justera styrkan av recoilen - Robin

    public float recoilforce; //hur stark ?r recoilen? - Robin
    public float ammo = 1; //en variabel som r?knar antalet ammo du har - Robin

    public Animator gunanim; //referens till gun animator - Robin

    public Animator playeranim; //referens till player animator - Robin

    public AudioSource gunshot; //referens till audiosource f?r pistol skottet - Robin
    public AudioClip gunshotclip; //referens till gunshot clip - Robin

    public void Shooting() //funktion som tar hand om Shooting - Robin
    {
            if(Input.GetKey(KeyCode.Space) && ammo >= 1)//om spelaren h?ller ned v?nster klick p? musen eller space knappen p? tangenbordet - Robin
            {
                gunshot.PlayOneShot(gunshotclip, 0.7f); //spela gunshot 1 g?ng - Robin
                Instantiate(bullet, new Vector3(bulletpoint.position.x, bulletpoint.position.y + 0.3f, bulletpoint.position.z), Quaternion.identity); //spawnar skottet p? bulletpoints position - Robin
                ammo -= 1; //s?ger att spelaren har skjutit ett skott - Robin
                recoil = true; //s?tter recoil till true - Robin
                player.transform.localScale += new Vector3(1f, 0.8f,0); //?kar spelarens scale - Robin
                playeranim.SetBool("shoot", true); //s?ter skjut animationen till true - Robin
                particles.SetActive(true); //s?tter p? partiklarna - Robin
                gunanim.SetBool("Shooting", true);
                 Instantiate(bulletparticle, new Vector3(player.transform.position.x + 0.5f, player.transform.position.y + 0.3f, 0), Quaternion.identity); //spawnar skottet - Robin
                StartCoroutine(Reload()); //startar den funktionen Reload som ?r en coroutine - Robin
            }



        if (recoil) //om recoil ?r true - Robin
        {
            CameraShake.shaking = true; //s?tter p? camerashake
            body.AddForce(-transform.up * 8000 * Time.deltaTime); //b?rja r?ra spelaren ned?t med velocityn 5000 - Robin
            StartCoroutine(Recoil()); //startar en coroutine - Robin
        }


        IEnumerator Recoil() //funktionen till coroutinen - Robin
        {
            yield return new WaitForSeconds(0.2f); //v?ntar i 0.2 sekunder - Robin       
            recoil = false; //s?tter recoil till false - Robin
            CameraShake.shaking = false; //st?nger av camera shake
            
        }
        IEnumerator Reload() //funktionen till coroutinen - Robin
        {
            yield return new WaitForSeconds(0.5f); //v?ntar i 0.15 sekunder - Robin
            gunanim.SetBool("spin", true); //s?tter snurr animationen till true - Robin
            player.transform.localScale = new Vector2(1, 1f); //g?r gubben till normal skala - Robin
            gunanim.SetBool("Shooting", false); //st?nger av skjut animation - Robin
            playeranim.SetBool("shoot", false); //st?nger av snurr animationen p? pistolen
            yield return new WaitForSeconds(0.3f); //v?ntar i 0.2 sekunder - Robin

            gunanim.SetBool("spin", false); //aktiverar snurr animationen p? pistolen - Robin
            yield return new WaitForSeconds(0.2f); //v?ntar i 0.2 sekunder - Robin
            particles.SetActive(false); //st?nger av partiklarna - Robin
            ammo = 1; //s?tter ammo till 1 - Robin
        }
    }
}
