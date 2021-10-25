using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDestroyer : MonoBehaviour
{
    public float secondsToDestroy = 2f;

    public void Start()
    {
        Destroy(gameObject, secondsToDestroy);
    }


}
