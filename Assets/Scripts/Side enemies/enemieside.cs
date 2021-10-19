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

    public GameObject varning1; //Ett gameobject som heter varning1- Elanor
    public GameObject varning2; //Ett gameobject som heter varning2- Elanor
    public GameObject varning3; //Ett gameobject som heter varning3- Elanor
    public GameObject varning4; //Ett gameobject som heter varning4- Elanor

    public Vector2 spawnpoint; //En vector2 variabel- Elanor

    public bool canstart; //En bool som jag har d�pt till canstart- Elanor 

    void Start()
    {
        position = Random.Range(1, 4); //Att min position kan va mellan 1 och 4- Elanor
    }
    
    // Update is called once per frame
    void Update()
    {
        if(position == 1) //Om position �r = 1?- Elanor
        {
            varning1.SetActive(true);
            spawnpoint = box1.position; //Kommer boxen spawna p� position 1- Elanor 
            movement.speed = Random.Range(10, 20); //Ger den en movementspeed som kan va mellan 10,20- Elanor 
            StartCoroutine(Deactivate()); //Callar min coroutin Deactivate- Elanor 
        }
        if (position == 2)  //Om position �r = 2?- Elanor
        {
            varning2.SetActive(true);
            spawnpoint = box2.position;//Kommer boxen spawna p� position 2- Elanor 
            movement.speed = Random.Range(10, 20); //Ger den en movementspeed som kan va mellan 10,20- Elanor 
            StartCoroutine(Deactivate()); //Callar min coroutin Deactivate- Elanor 
        }
        if (position == 3)  //Om position �r = 3?- Elanor
        {
            varning3.SetActive(true);
            spawnpoint = box3.position;//Kommer boxen spawna p� position 3- Elanor 
            movement.speed = Random.Range(-10, -20); //Ger den en movementspeed som kan va mellan 10,20- Elanor 
            StartCoroutine(Deactivate()); //Callar min coroutin Deactivate- Elanor 
        }
        if (position == 4)  //Om position �r = 4?- Elanor
        {
            varning4.SetActive(true);
            spawnpoint = box4.position;//Kommer boxen spawna p� position 4- Elanor 
            movement.speed = Random.Range(-10, -20); //Ger den en movementspeed som kan va mellan 10,20- Elanor 
            StartCoroutine(Deactivate()); //Callar min coroutin Deactivate- Elanor 
        }

        if (canstart) //Om canstart?
        {
            Instantiate(box, (spawnpoint), Quaternion.identity); //Spawnar boxen p� spawnpointen- Elanor
            position = 0; //Att positionen variabeln blir 0- Elanor
            StartCoroutine(Spawnagain()); //Callar min coroutin- Elanor 
            canstart = false; //Canstart �r falsk (kan inte spawna mer objekts)- Elanor
        }
    }

    IEnumerator Spawnagain() //Coroutin- Elanor 
    {
        yield return new WaitForSeconds(Random.Range(10, 20)); //Den v�ntar mellan 10,20 sekunder innan det kommer ett nytt objekt- Elanor
        position = Random.Range(1, 4); //Att min position kan va mellan 1 och 4- Elanor
        canstart = true; //Canstart �r true- Elanor

    }

    IEnumerator Deactivate() //Coroutin- Elanor
    {
        yield return new WaitForSeconds(1.5f); //Den v�ntar 1.5 sek innan n�nting h�nder igen- Elanor 
        varning1.SetActive(false); //varning1 blir falsk- Elanor 
        varning2.SetActive(false); //varning2 blir falsk- Elanor 
        varning3.SetActive(false); //varning3 blir falsk- Elanor 
        varning4.SetActive(false); //varning4 blir falsk- Elanor 
    }
}
