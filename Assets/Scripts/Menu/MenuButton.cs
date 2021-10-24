using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    [SerializeField] Animator animator;
    [SerializeField] AnimatorFunctions animatorFunctions;
    [SerializeField] int thisIndex; // 
    
    

    // Update is called once per frame
    void Update()
    {
        if (menuButtonController.index == thisIndex) // if the menubuttoncontroller,if the index value is the same as this current index the index that we've set manually for each individual button then we're going to fire the correct animator scripts
        {
            //Summary for Henry we're setting booleans for our animator and those are gonna tell the stat machine what to play 
            
            animator.SetBool ("selected" , true); // we set the boolean selected to true 
            if (Input.GetAxis ("Submit") == 1)//  we check and see if we're pressing the submit button which is the enter button the space button and the submit button is a float value so it's like the axises 0
            {
                animator.SetBool("pressed", true);// if the user presses enter or space it jumps immediately to one or back down when they release 
            } else if (animator.GetBool("pressed"))// if it's set to 0 not one,  meaning they release the button
            {
                animator.SetBool("pressed", false);// it's going to set the boolean back to false 
                animatorFunctions.disableOnce = true;//it's going to set the variable disableOnce  to true 
                
            } else
                    animator.SetBool("selected", false);// if it's not equal to the current index then it's just gonna go back to selected false.
            
            }
        }    
}
