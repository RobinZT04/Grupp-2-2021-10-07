using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public int index;
    [SerializeField] bool keyDown;
    [SerializeField] int maxIndex;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // it's just referencing Audiosource component in our game object 
    }

    // Update is called once per frame
    void Update(){
        //the moment they release the key meaning the moment the input axis for vertical is set to 0 
        if (Input.GetAxis ("Vertical") != 0) { // we are going to check if their vertical axis for their input meaning pressing Up or Down  and if it's not equal to 0 it will start incrementing our index variables
            if (!keyDown){ // this will check and it will say if the user has pressed the key we can fire all the code from here down to KeyDown = true;
                if (Input.GetAxis ("Vertical") < 0) { // this is checking if vertical is smaller than 0 meaning if the user pressed Down 
                    if(index < maxIndex){ // if index is smaller then maxindex 
                        index++; // we are going to increase our index 
                        }else{
                           index = 0;
                        }
                    } else if(Input.GetAxis ("Vertical") > 0) { // if they press Up which is greater than 0
                    if (index > 0) { // if index is than zero 
                        index--; // it will decrease the index meaning go backwards on the list...... we can actually go down n our index but if it is 0 it will go to our maxindex 
                    } else {
                        index = maxIndex; // mmeaning take us from Player down to quit so like creating a loop effect
                    }
                 }
                keyDown = true; // Right after it's all fried keyDown is set to true so that the condition is no longer met 
            }
        } else {
            keyDown = false; // then it's gonna be set back to false meaning they realse the key and they can press it again and again untill Henry puts a virus here(:
        }

    }
}
