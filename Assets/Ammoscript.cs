using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammoscript : MonoBehaviour
{ 
    void Start()
    {
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.8f);
        Destroy(this);
        Destroy(gameObject);
    }
}
