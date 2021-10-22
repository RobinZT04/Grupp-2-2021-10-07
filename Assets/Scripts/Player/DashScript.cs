using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour, IDash
{
    public bool dash; //dashar gubben? - Robin
    public bool candash; //kan gubben dasha? - Robin
    public Rigidbody2D body; //referens till rigidbody2D - Robin
    public float dashspeed; //hur snabbt dashar man - Robin
    public GameObject clock;
    public void Start()
    {
        dash = false; //dashar inte - Robin
        candash = true; //kan dasha - Robin
    } 
    public void Dashing() //funktion som heter Dashing - Robin
    {
        if (Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.LeftShift) && (!dash)) //om du h�ller in W, shift och om du kan dasha - Robin
        {
            dashspeed = -15000; //s�tt dashspeed till -8000 - Robin
            if (candash) //om du kan dasha - Robin
            {
                dash = true; //s�tt dash till true - Robin
            }
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift) && (!dash)) //om du h�ller in S, shift och om du kan dasha - Robin
        {
            dashspeed = 15000; //s�tt dashspeed till 8000 - Robin
            if (candash) //om du kan dasha - Robin
            {
                dash = true; //dash �r true - Robin
            }
        }


        if (dash && candash) //om dash �r true och du kan dasha - Robin
        {
            body.AddForce(-transform.up * dashspeed * Time.deltaTime); //b�rja r�ra spelaren nmed dashspeed - Robin
            StartCoroutine(Dash()); //startar en coroutine - Robin
        }
       
    }
    IEnumerator Dash() //IEnumerator funktion som heter Dash - Robin
    {
        clock.SetActive(true);
        Time.timeScale = 0.25f; //s�tter time till [tid v�rdet] - Robin
        yield return new WaitForSeconds(0.3f); //v�nta [antal sekunder] - Robin
        clock.SetActive(false);
        Time.timeScale = 1f; //s�tter time till [tid v�rdet] - Robin
        dash = false; //s�tter dash till false - Robin
        candash = false; //s�tter candash till false - Robin
        yield return new WaitForSeconds(1); //v�nta [antal sekunder] - Robin
        candash = true; //candash �r true - Robin
    }
}
