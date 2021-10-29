using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
   public static float hp; //En referen f�r hp som �r en float - Elanor 

    public Animator table; //En animator f�r table- Elanor 
    public Animator pole; //En animator f�r pole - Elanor 
    public Animator barrel; //En animator f�r barrel - Elanor
    
    public AudioSource broken; //En referrns till min audiosource i unity- Elanor 
    public AudioClip brokenclip; //En referens till sj�lva lkud klippet- Elanor



    // Start is called before the first frame update
    void Start()
    {
        hp = 3; //Att hp ska vara p� 3 hp n�r man b�rjar spelet- Elanor 
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
        if (hp ==1) //Om Hp �r p� 1?
        {
            table.SetBool("hpone", true); //Att tables bool "hpone" i animatorn ska bli true- Elanor 
            pole.SetBool("hpone", true); //Att poles bool "hpone" i animatorn ska bli true- Elanor 
            barrel.SetBool("hpone", true); //Att barrels bool "hpone" i animatorn ska bli true- Elanor 
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.transform.tag == "Enemy") //Om n�got g�r in i barri�ren med tagen "enemy"?- Elanor 
        {
            hp -= 1; //S� kommer barri�ren ta -1 hp- Elanor
            broken.PlayOneShot(brokenclip, 0.7f); //Spela ett ljudklipp som �r brokenclip med volymen 0,7- Elanor
        }
    }
}
