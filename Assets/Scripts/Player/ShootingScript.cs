using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour, IShoot
{
    public GameObject bullet; //referens till bullet prefab - Robin
    public Transform bulletpoint; //refrens till bulletpoint position - Robin
    public Rigidbody2D body; //en referens till rigidbody2D:n - Robin
    public bool recoil; //variabel bool till recoil - Robin

    public void Shooting() //funktion som tar hand om Shooting - Robin
    {

        if(Input.GetMouseButtonDown(0)) //om spelaren håller ned vänster klick på musen - Robin
        {
            recoil = true; //sätter recoil till true - Robin
            Instantiate(bullet, new Vector3(bulletpoint.position.x, bulletpoint.position.y + 0.3f, bulletpoint.position.z), Quaternion.identity); //spawnar skottet på bulletpoints position - Robin
        }
        if (recoil) //om recoil är true - Robin
        {
            body.AddForce(-transform.up * 5000 * Time.deltaTime); //börja röra spelaren nedåt med velocityn 5000 - Robin
            StartCoroutine(Recoil()); //startar en coroutine - Robin
        }
        IEnumerator Recoil() //funktionen till coroutinen - Robin
        {
            yield return new WaitForSeconds(0.2f); //väntar i 0.2 sekunder - Robin
            recoil = false; //sätter recoil till false - Robin
        }
    }
}
