using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorFunctions : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    public bool disableOnce;
    
    void PlayerSound(AudioClip whichSound) 
    {
        if (!disableOnce)
        {
            menuButtonController.audioSource.PlayOneShot(whichSound);// telling the audiosource which is on the controller to play oneshot which is gonna play a single sound really quick almost as quick as the flash and then it's gonna play which sound which is the parameter whichSound.
        }else{
            disableOnce = false;
        }
    }
    
}
