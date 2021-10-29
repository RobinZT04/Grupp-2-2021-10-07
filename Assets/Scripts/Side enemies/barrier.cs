using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
   public float hp; //En referen för hp som är en float - Elanor 

    public Animator table; //En animator för table- Elanor 
    public Animator pole; //En animator för pole - Elanor 
    public Animator barrel; //En animator för barrel - Elanor
    
    public AudioSource broken; //En referrns till min audiosource i unity- Elanor 
    public AudioClip brokenclip; //En referens till själva lkud klippet- Elanor



    // Start is called before the first frame update
    void Start()
    {
        hp = 3; //Att hp ska vara på 3 hp när man börjar spelet- Elanor 
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 2) //Om hp blir 2?- Elanor 
        {
            table.SetBool("hptwo", true); //Att tables bool "hptwo" i animatorn ska bli true- Elanor 
            pole.SetBool("hptwo", true); //Att polens bool "hptwo" i animatorn ska bli true- Elanor 
            barrel.SetBool("hptwo", true); //Att barrels bool "hptwo" i animatorn ska bli true- Elanor 
        }
        if (hp ==1) //Om Hp är på 1?
        {
            table.SetBool("hpone", true); //Att tables bool "hpone" i animatorn ska bli true- Elanor 
            pole.SetBool("hpone", true); //Att poles bool "hpone" i animatorn ska bli true- Elanor 
            barrel.SetBool("hpone", true); //Att barrels bool "hpone" i animatorn ska bli true- Elanor 
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.transform.tag == "Enemy") //Om något går in i barriären med tagen "enemy"?- Elanor 
        {
            hp -= 1; //Så kommer barriären ta -1 hp- Elanor
            broken.PlayOneShot(brokenclip, 0.7f); //Spela ett ljudklipp som är brokenclip med volymen 0,7- Elanor
        }
    }
}
