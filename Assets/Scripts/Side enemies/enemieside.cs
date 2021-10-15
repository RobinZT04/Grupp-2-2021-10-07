using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemieside : MonoBehaviour
{
    public float position; //En float variabel- Elanor
    public GameObject box; //Ett gameobject som heter box- Elanor

    public Transform box1; //En referens till box1- Elanor 
    public Transform box2; //En referens till box2- Elanor 
    public Transform box3; //En referens till box3- Elanor 
    public Transform box4; //En referens till box4- Elanor 

    public Vector2 spawnpoint; //En vector2 variabel- Elanor

    public bool canstart; //En bool som jag har döpt till canstart- Elanor 

    void Start()
    {
        position = Random.Range(1, 4); //Att min position kan va mellan 1 och 4- Elanor
    }
    
    // Update is called once per frame
    void Update()
    {
        if(position == 1) //Om position är = 1?- Elanor
        {
            spawnpoint = box1.position; //Kommer boxen spawna på position 1- Elanor 
            movement.speed = Random.Range(10, 20); //Ger den en movementspeed som kan va mellan 10,20- Elanor 
        }
        if (position == 2)  //Om position är = 2?- Elanor
        {
            spawnpoint = box2.position;//Kommer boxen spawna på position 2- Elanor 
            movement.speed = Random.Range(10, 20); //Ger den en movementspeed som kan va mellan 10,20- Elanor 
        }
        if (position == 3)  //Om position är = 3?- Elanor
        {
            spawnpoint = box3.position;//Kommer boxen spawna på position 3- Elanor 
            movement.speed = Random.Range(-10, -20); //Ger den en movementspeed som kan va mellan 10,20- Elanor 
        }
        if (position == 4)  //Om position är = 4?- Elanor
        {
            spawnpoint = box4.position;//Kommer boxen spawna på position 4- Elanor 
            movement.speed = Random.Range(-10, -20); //Ger den en movementspeed som kan va mellan 10,20- Elanor 
        }

        if (canstart) //Om canstart?
        {
            Instantiate(box, (spawnpoint), Quaternion.identity); //Spawnar boxen på spawnpointen- Elanor
            StartCoroutine(Spawnagain()); //Callar min coroutin- Elanor 
            canstart = false; //Canstart är falsk (kan inte spawna mer objekts)- Elanor
        }
    }

    IEnumerator Spawnagain() //Coroutin- Elanor 
    {
        yield return new WaitForSeconds(Random.Range(10, 20)); //Den väntar mellan 10,20 sekunder innan det kommer ett nytt objekt- Elanor
        position = Random.Range(1, 4); //Att min position kan va mellan 1 och 4- Elanor
        canstart = true; //Canstart är true- Elanor

    }

}
