using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody2D body; //referens till spelaren Rigidbody2D - Robin

    [Range(1000f, 8000f)] //gör en "slider" i inspectorn vilket gör det lättare att justera fart till spelaren - Robin
    public float speed; //variabel till speed - Robin

    void Start()
    {
       
    }

    void Update()
    {
        float vert = Input.GetAxis("Vertical"); //gör en float variabel som heter vert och ger den värdet av input.getaxis av "Vertical" - Robin
        float horiz = Input.GetAxis("Horizontal"); //gör en float variabel som heter horiz och ger den värdet av input.getaxis av "Horizontal" - Robin

        body.velocity = new Vector2(horiz * speed * Time.deltaTime, vert * speed * Time.deltaTime); //sätter body.velocity till horizons velocity samt verticals velocity - Robin
    }
}
