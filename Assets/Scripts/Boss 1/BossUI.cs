using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossUI : MonoBehaviour
{

   
    

    public static BossUI instance;

    private void Awake()
    {
        if(instance == null )
        {
            instance = this;  
        }
    }

   
}
