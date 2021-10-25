using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour, IWalk
{
    public Animator playeranim; //referens till spelaren animator - Robin

    public Rigidbody2D body; //referens till spelaren Rigidbody2D - Robin

    [Range(200f, 1500f)] //gör en "slider" i inspectorn vilket gör det lättare att justera fart till spelaren - Robin
    public float speed; //variabel till speed - Robin


    public void Walking()
    {
        float vert = Input.GetAxis("Vertical"); //gör en float variabel som heter vert och ger den värdet av input.getaxis av "Vertical" - Robin
        float horiz = Input.GetAxis("Horizontal"); //gör en float variabel som heter horiz och ger den värdet av input.getaxis av "Horizontal" - Robin

        body.velocity = new Vector2(horiz * speed * Time.deltaTime, vert * speed * Time.deltaTime); //sätter body.velocity till horizons velocity samt verticals velocity - Robin

        if (body.velocity.magnitude > 0) //om spelaren velocity är högre än 0  - Robin
        {
            playeranim.SetBool("Walking", true); //spela walking animation  - Robin
        }
        else //annars - Robin
        {
            playeranim.SetBool("Walking", false); //spela inte walking animation
        }

    }
}
