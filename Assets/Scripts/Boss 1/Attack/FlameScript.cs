using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameScript : MonoBehaviour
{
    float moveSpeed;
    Rigidbody2D rb2d;
    Vector2 moveDirection;
    PlayerController target;


    // Start is called before the first frame update
    private void Start()
    {
        moveSpeed = GetComponent<Boss>().speed; //The movespeed is the same as Getcomponent Boss speed
        rb2d = GetComponent<Rigidbody2D>(); // rb2d is the rigidbody that is inside the gameobject
        target = PlayerController.instance; // the instance that the playercontroller has meaning the Player

        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed; // we move the flame to the direction our boss moves, target.transform.position so the position of our character - the position of our flame meaning it will direct to our player * movespeed 
        rb2d.velocity = new Vector2(moveDirection.x, moveDirection.y); // the velocity of our rb2d will be the same as the direction as X and the direction of Y 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
