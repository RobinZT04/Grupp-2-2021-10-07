using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour, IGrenade
{
    public GameObject indicator;
public void Throwing()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            indicator.SetActive(true);
        }
        else if(Input.GetKeyUp(KeyCode.Q))
        {
            indicator.SetActive(false);
        }
    }   
}
