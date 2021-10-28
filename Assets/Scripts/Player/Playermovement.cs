using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour, IWalk
{
    public Animator playeranim; //referens till spelaren animator - Robin

    public Rigidbody2D body; //referens till spelaren Rigidbody2D - Robin

    [Range(200f, 1500f)] //g�r en "slider" i inspectorn vilket g�r det l�ttare att justera fart till spelaren - Robin
    public float speed; //variabel till speed - Robin

    public AudioClip walkingclip; //referens till walking clip - Robin
    public AudioSource walking; //referens till walking audio source - Robin 

    public bool playing;

    public void Start()
    {
        playing = false;
    }

    public void Walking()
    {
        float vert = Input.GetAxis("Vertical"); //g�r en float variabel som heter vert och ger den v�rdet av input.getaxis av "Vertical" - Robin
        float horiz = Input.GetAxis("Horizontal"); //g�r en float variabel som heter horiz och ger den v�rdet av input.getaxis av "Horizontal" - Robin

        body.velocity = new Vector2(horiz * speed * Time.deltaTime, vert * speed * Time.deltaTime); //s�tter body.velocity till horizons velocity samt verticals velocity - Robin

        if (body.velocity.magnitude > 0) //om spelaren velocity �r h�gre �n 0  - Robin
        {
            playeranim.SetBool("Walking", true); //spela walking animation  - Robin
            if (!walking.isPlaying)
            {
                walking.Play();
            }
            
        }
        else //annars - Robin
        {
            playeranim.SetBool("Walking", false); //spela inte walking animation
            walking.Stop();
        }
    }
}
