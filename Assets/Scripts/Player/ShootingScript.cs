using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour, IShoot
{
    public GameObject bullet; //referens till bullet prefab - Robin

    public Transform bulletpoint; //refrens till bulletpoint position - Robin

    public Rigidbody2D body; //en referens till rigidbody2D:n - Robin

    public bool recoil; //variabel bool till recoil - Robin

    [Range(200f, 10000f)]  //g�r en "slider" i inspectorn vilket g�r det l�ttare att justera styrkan av recoilen - Robin

    public float recoilforce; //hur stark �r recoilen? - Robin
    public float hasshot = 0; //en variabel som r�knar skotten du avfyrat - Robin

    public void Shooting() //funktion som tar hand om Shooting - Robin
    {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) && (hasshot <= 1)) //om spelaren h�ller ned v�nster klick p� musen eller space knappen p� tangenbordet - Robin
            {
                Instantiate(bullet, new Vector3(bulletpoint.position.x, bulletpoint.position.y + 0.3f, bulletpoint.position.z), Quaternion.identity); //spawnar skottet p� bulletpoints position - Robin
                hasshot += 1; //s�ger att spelaren har skjutit ett skott - Robin
                recoil = true; //s�tter recoil till true - Robin
            }
        if (recoil) //om recoil �r true - Robin
        {
            body.AddForce(-transform.up * 5000 * Time.deltaTime); //b�rja r�ra spelaren ned�t med velocityn 5000 - Robin
            StartCoroutine(Recoil()); //startar en coroutine - Robin
        }
        IEnumerator Recoil() //funktionen till coroutinen - Robin
        {
            yield return new WaitForSeconds(0.2f); //v�ntar i 0.2 sekunder - Robin
            recoil = false; //s�tter recoil till false - Robin
            yield return new WaitForSeconds(1f); //v�ntar i 0.2 sekunder - Robin
            hasshot = 0; //s�tter antalet skott som avfyrats till 0 - Robin
        }
    }
}
