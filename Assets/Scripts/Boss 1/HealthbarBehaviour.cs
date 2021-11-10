using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Everything made by José Luis
public class HealthbarBehaviour : MonoBehaviour
{
    public Slider slider;
    public Color Low;
    public Color High;
    public Vector3 Offset; // Don't need this for this game
   
    // Start is called before the first frame update
/*
    public void SetHealth(float health, float maxHealth)
    {
        slider.gameObject.SetActive(health < maxHealth); // So what this does is that it will setactive if we damage the boss if we don't it wont show ut the health
        slider.value = health; // we are setting the sliders value property to our current health
        slider.maxValue = maxHealth; // and the sliders maxValue property with our maxhealth


        slider.fillRect.GetComponent<Image>().color = Color.Lerp(Low, High, slider.normalizedValue); // we set the color of the healthbar depending on how damaged the boss is 
    }


    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.position + Offset); // it basically transform the position from 3d world position to a 2d screen point
    }
    */
}
