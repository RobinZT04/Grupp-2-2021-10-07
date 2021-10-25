using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour, IDash
{
    public bool dash; //dashar gubben? - Robin
    public bool candash; //kan gubben dasha? - Robin
    public Rigidbody2D body; //referens till rigidbody2D - Robin
    public float dashspeed; //hur snabbt dashar man - Robin
    public GameObject clock; //referns till UI klockan - Robin
    public void Start()
    {
        dash = false; //dashar inte - Robin
        candash = true; //kan dasha - Robin
    } 
    public void Dashing() //funktion som heter Dashing - Robin
    {
        if (Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.LeftShift) && (!dash)) //om du håller in W, shift och om du kan dasha - Robin
        {
            dashspeed = -15000; //sätt dashspeed till -8000 - Robin
            if (candash) //om du kan dasha - Robin
            {
                dash = true; //sätt dash till true - Robin
            }
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift) && (!dash)) //om du håller in S, shift och om du kan dasha - Robin
        {
            dashspeed = 15000; //sätt dashspeed till 8000 - Robin
            if (candash) //om du kan dasha - Robin
            {
                dash = true; //dash är true - Robin
            }
        }


        if (dash && candash) //om dash är true och du kan dasha - Robin
        {
            body.AddForce(-transform.up * dashspeed * Time.deltaTime); //börja röra spelaren nmed dashspeed - Robin
            StartCoroutine(Dash()); //startar en coroutine - Robin
        }
       
    }
    IEnumerator Dash() //IEnumerator funktion som heter Dash - Robin
    {
        clock.SetActive(true); //sätter på klockan som visar att man dashar - Robin
        Time.timeScale = 0.25f; //sätter time till [tid värdet] - Robin
        yield return new WaitForSeconds(0.3f); //vänta [antal sekunder] - Robin
        clock.SetActive(false); //stänger av klockan som visar att man dashar - Robin
        Time.timeScale = 1f; //sätter time till [tid värdet] - Robin
        dash = false; //sätter dash till false - Robin
        candash = false; //sätter candash till false - Robin
        yield return new WaitForSeconds(1); //vänta [antal sekunder] - Robin
        candash = true; //candash är true - Robin
    }
}
