using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript : MonoBehaviour
{
    public Rigidbody2D indicator;
    public Transform player;
    private void Update()
    {
        transform.position += new Vector3(0, 1, 0);
    }

}
