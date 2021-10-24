using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossUI : MonoBehaviour
{

    public GameObject bossPanel;
    public GameObject tablewalls;

    public static BossUI instance;

    private void Awake()
    {
        if(instance == null )
        {
            instance = this;  
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        bossPanel.SetActive(false);
        tablewalls.SetActive(false);
    }

    // Update is called once per frame
    public void BossActivator()
    {
        bossPanel.SetActive(true);
        tablewalls.SetActive(true);
    }
}
