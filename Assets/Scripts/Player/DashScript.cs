using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour, IDash
{
    public bool dash;
    public bool candash;
    public Rigidbody2D body;
    public float dashspeed;

    public Animator playeranim;

    public void Start()
    {
        dash = false;
        candash = true;
    }
    public void Dashing()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && (!dash)) //om recoil är true - Robin
        {
            dashspeed = -8000;
            if (candash)
            {
                dash = true;
            }
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift) && (!dash)) //om recoil är true - Robin
        {
            dashspeed = 8000;
            if (candash)
            {
                dash = true;
            }
        }


        if (dash == true && candash)
        {
            body.AddForce(-transform.up * dashspeed * Time.deltaTime); //börja röra spelaren nedåt med velocityn 5000 - Robin
            StartCoroutine(Dash()); //startar en coroutine - Robin
            playeranim.SetBool("dash", true);
        }
        IEnumerator Dash()
        {
            yield return new WaitForSeconds(0.3f);
            playeranim.SetBool("dash", false);
            dash = false;
            candash = false;
            yield return new WaitForSeconds(1);
            candash = true;
        }
    }
}
