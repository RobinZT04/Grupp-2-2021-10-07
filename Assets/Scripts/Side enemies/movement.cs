using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D body; //En rigedbody med namnet body- Elanor

    public static float speed; //En variabel som jag även har återkomst till i andra scripts- Elanor 


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroybox()); //Callar min Coroutine som heter Destroybox- Elanor
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(speed, 0); //Ger bodyn velocity- Elanor

        if (enemieside.turnedrat)
        {
            Debug.Log("funkar1");
            transform.eulerAngles = (new Vector3(0, 180, 0));
            Debug.Log("funkar");
        } else
        {
            transform.eulerAngles = (new Vector3(0, 0, 0));
        }
    }

    IEnumerator Destroybox() //Min coroutine- Elanor 
    {
        yield return new WaitForSeconds(6); //Vänta i 10 sekunder innan nästa del händer- Elanor 
        Destroy(gameObject); //Objectet förstöra sig själv (efter då 10 sekunder)- Elanor
    }

}
