using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Made by José Luis
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Camera cam;

    Vector2 movment;

    Vector2 mousePos;

    public static PlayerController instance;

    public ProjectileBehaviour ProjectilePrefab;
    public Transform LunchOffset;

    void Update()
    {
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); // this will just convert our mouse position from pixel coordinates to world units and by the way now we know where our mouse is on our screen

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LunchOffset.position, transform.rotation);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime); // Move our object to our current poisition + and our movment-vector and multiply this with our movespeed to be abel to control the speed of this movment. and with Time.fiexedDeltaTime it will just make sure that the speed of movment won't depend on how many times a fixed update is called.

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

}