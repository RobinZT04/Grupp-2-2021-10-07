using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTopCounter : MonoBehaviour
{
    [SerializeField]
    public static float EnemyCounter;

    public Text scoreText;

    public GameObject boss;

    // Start is called before the first frame update
    void Start()
    {
        boss.SetActive(false);
        EnemyCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyCounter <= 100)
        {
            boss.SetActive(true);
        }

        scoreText.text = "Kills: " + EnemyCounter;

        Debug.Log(EnemyCounter);
    }
}