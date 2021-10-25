using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Vector2 amplitude; //vector 2 variabel för amplitude värden - Robin
    public Vector2 freq; //vector 2 variabel för frequens värden - Robin
    public Vector2 time; //vector 2 variabel för time värden - Robin

    public static bool shaking; //skakar skärmen? - Robin


    // Update is called once per frame
    void Update()
    {
        if (shaking) //är shaking true? - Robin
        {
            time.x += Time.deltaTime * freq.x; //öka time.x med freq.x - Robin
            time.y += Time.deltaTime * freq.y; //öka time.y med freq.y - Robin

            Vector3 shakePos = transform.localPosition; //en local variabel som heter shakePos till transform.localposition - Robin
            shakePos.x = Mathf.Sin(time.x) * amplitude.x; //ökar shakePos/transform.localposition med sin(time.x) * amplitude.x - Robin
            shakePos.y = Mathf.Sin(time.y) * amplitude.y; //ökar shakePos/transform.localposition med sin(time.y) * amplitude.y - Robin

            transform.localPosition = shakePos; //sätter transform.localPosition till shakePos - Robin
        }
        else //annars - Robin
        {
            transform.localPosition = new Vector3(0, 0, -10); //sätt den lokala positionen till (0,0,-10) -10 finns eftersom att man annars inte kan se objekten/spritesen - Robin
        }
    }
}
