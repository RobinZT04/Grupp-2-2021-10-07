using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
   public float hp;

    public Animator table;
    public Animator pole;
    public Animator barrel;


    // Start is called before the first frame update
    void Start()
    {
        hp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 2)
        {
            table.SetBool("hptwo", true);
            pole.SetBool("hptwo", true);
            barrel.SetBool("hptwo", true);
        }
        if (hp ==1) 
        {
            table.SetBool("hpone", true);
            pole.SetBool("hpone", true);
            barrel.SetBool("hpone", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            hp -= 1;
        }
    }
}
