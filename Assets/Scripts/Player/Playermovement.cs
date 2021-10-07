using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour, IWalk
{
    public Rigidbody2D body; //referens till spelaren Rigidbody2D - Robin

    [Range(200f, 1500f)] //g�r en "slider" i inspectorn vilket g�r det l�ttare att justera fart till spelaren - Robin
    public float speed; //variabel till speed - Robin


    public void Walking()
    {
        float vert = Input.GetAxis("Vertical"); //g�r en float variabel som heter vert och ger den v�rdet av input.getaxis av "Vertical" - Robin
        float horiz = Input.GetAxis("Horizontal"); //g�r en float variabel som heter horiz och ger den v�rdet av input.getaxis av "Horizontal" - Robin

        body.velocity = new Vector2(horiz * speed * Time.deltaTime, vert * speed * Time.deltaTime); //s�tter body.velocity till horizons velocity samt verticals velocity - Robin
    }
}
