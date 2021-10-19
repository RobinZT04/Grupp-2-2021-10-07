using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D body; //En rigedbody med namnet body- Elanor

    public static float speed; //En variabel som jag �ven har �terkomst till i andra scripts- Elanor 


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroybox()); //Callar min Coroutine som heter Destroybox- Elanor
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(speed, 0); //Ger bodyn velocity- Elanor
    }

    IEnumerator Destroybox() //Min coroutine- Elanor 
    {
        yield return new WaitForSeconds(10); //V�nta i 10 sekunder innan n�sta del h�nder- Elanor 
        Destroy(gameObject); //Objectet f�rst�ra sig sj�lv (efter d� 10 sekunder)- Elanor
    }

}
