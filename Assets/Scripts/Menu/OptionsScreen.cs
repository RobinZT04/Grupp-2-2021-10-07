using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;
public class OptionsScreen : MonoBehaviour
{
    //Everything here is made by José Luis
    public Toggle fullscreenTog, vsyncTog;

    public List<ResItem> resolutions = new List<ResItem>();

    private int selectedResolution;

    public TMP_Text resolutionLabel;

    public AudioMixer theMixer;

    public TMP_Text mastLabel, musicLabel, sfxLabel;

    public Slider mastSlider, musicSlider, sfxSlider;

    // Start is called before the first frame update
    void Start()
    {
        fullscreenTog.isOn = Screen.fullScreen; // our full screen toggle dot is on whether it's true or false basically is equal to screen dot fullscreen. So screen that's fullscreen is how we can find out is the game running fullscreen.
        
        if(QualitySettings.vSyncCount == 0) //-__- we do a check  so if qualitySetting.VsyncCount == 0) So VsyncCount is howmany Vsync is trying to have with your monitors so basically if you have Vsync(0) it means that you have no Vsync and VsyncCount(1) is 60 FPS
        {
            vsyncTog.isOn = false; // our vsync is on 0 so not on at the moment
        } else
        {
            vsyncTog.isOn = true; // if the vsync is any other value like Henrys favorite number one or two or whatever.
        }

        bool foundRes = false; // we make this to find the correct resolution 
        for(int i = 0; i < resolutions.Count; i++) // we are looping through all the resolutions one by one that we have currently 
        {
            if (Screen.width == resolutions[i].horizontal && Screen.height == resolutions[i].vertical) //check is the resolution equal to 1920 on the width and 1080 on the height is equal to or is it equal to 1280 on the width and 720 on the height and so on and on. 
            {
                foundRes = true; // if that is the case we'll then set 

                selectedResolution = i; // our second resolution is whatever loop we're currently on 

                UpdateResLabel(); // we are going to update the resolution label to display the correct one 
            }

        }


        if(!foundRes) // if we have not found the resolution 
        {
            ResItem newRes = new ResItem();// we are basically creating a new blank one to use 
            newRes.horizontal = Screen.width; // we are assigning the newRes dot horizontal to be equal to whatever our screen width is, to whatever strange size Henry has set up that isn't avalibel in our options 
            newRes.vertical = Screen.height;

            resolutions.Add(newRes); // we are adding the new Res item because we're adding that to the end of the list basically 
            selectedResolution = resolutions.Count - 1;  

            UpdateResLabel();
        }

        float vol = 0f; // just a holder value 
        theMixer.GetFloat("Master Vol", out vol); // from themMixer we want to get the float for Master vol and now we are telling it that Henry want's to send the value that we get we want to send it out to the volume/vol variable that i created 
        mastSlider.value = vol; // and then we can tell the master slider  that value to be equal to whatever our volume is 

        theMixer.GetFloat("Music Vol", out vol); // from themMixer we want to get the float for Music vol and now we are telling it that Henry want's to send the value that we get we want to send it out to the volume/vol variable that i created 
        musicSlider.value = vol; // and then we can tell the Music slider  that value to be equal to whatever our volume is 

        theMixer.GetFloat("SFX Vol", out vol); // from themMixer we want to get the float for SFX vol and now we are telling it that Henry want's to send the value that we get we want to send it out to the volume/vol variable that i created 
        sfxSlider.value = vol; // and then we can tell the SFX slider  that value to be equal to whatever our volume is 

        mastLabel.text = Mathf.RoundToInt(mastSlider.value + 80).ToString();

        musicLabel.text = Mathf.RoundToInt(musicSlider.value + 80).ToString();

        sfxLabel.text = Mathf.RoundToInt(sfxSlider.value + 80).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResLeft()
    {
        selectedResolution--; // when we press left the number will go down 
        if(selectedResolution < 0) // if our selected resolution is less then 0 
        {
            selectedResolution = 0; // then selectedResolution = 0 
        }
        UpdateResLabel(); // we want it to be updated whenever we switch our resolution left 
    }

    public void ResRight()
    {
        selectedResolution++; // when we press right the number will go up 
        if(selectedResolution > resolutions.Count - 1) // we have three different resolutions so if the resolution becomes greater than 2 which is the highest value that we can go to in our array in the Option screen back in Unity so element 2.
        {
            selectedResolution = resolutions.Count - 1; // if it becomes higher than 2 then we will make sure that it is always set to be selectedresolutions = resolutions count -1 so this means that the maximum in our current situation is two.
        }

        UpdateResLabel();// or whenever we switch our resolution right 
    }
        
    public void UpdateResLabel()
    {
        resolutionLabel.text = resolutions[selectedResolution].horizontal.ToString() + " x " + resolutions[selectedResolution].vertical.ToString(); // The text value on the resolutionlabel object whitch is in unity optionscreen and resolutionitem and in the Res label button and in there it will say Text(TMP) which is the bit of text we're going to to use and then we will access the text box in the Text(TMP)
    }  // that text element is equal to from our resolutions array at whatever our selected resolution is, we want to use the Horizontal value and then we want to convert this into a string value tostring, I'm going to say plus and then space x space in quotation marks and then plus again resolutions at selected resolution dot vertical dot tostring 

    public void ApplyGraphics()
    {
       // Screen.fullScreen = fullscreenTog.isOn; // our screen dot fullscreen should be equal to fullscreenTog dot is on so basically if our toggle is on or not

        if (vsyncTog.isOn) // if our vsynctog is on 
        {
            QualitySettings.vSyncCount = 1; // that means we want vSync so 
        }
        else // otherwise 
        {
            QualitySettings.vSyncCount = 0; // so it's not on 
        }

        Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, fullscreenTog.isOn); // we put in the width, height and we also have to pass in whether it's full screen or not
    }

    public void SetMasterVol()
    {
        mastLabel.text = Mathf.RoundToInt(mastSlider.value + 80).ToString(); // we update the text that is displayed, i've done now so that we wont need to see the 80 in unity and so that we wont see the decimals.

        theMixer.SetFloat("Master Vol", mastSlider.value);

        PlayerPrefs.SetFloat("Master Vol", mastSlider.value); 
    }

    public void SetMusicVol()
    {
        musicLabel.text = Mathf.RoundToInt(musicSlider.value + 80).ToString(); // we update the text that is displayed, i've done now so that we wont need to see the 80 in unity and so that we wont see the decimals.

        theMixer.SetFloat("Music Vol", musicSlider.value);

        PlayerPrefs.SetFloat("Music Vol", musicSlider.value);
    }

    public void SetSFXVol()
    {
        sfxLabel.text = Mathf.RoundToInt(sfxSlider.value + 80).ToString(); // we update the text that is displayed, i've done now so that we wont need to see the 80 in unity and so that we wont see the decimals.

        theMixer.SetFloat("SFX Vol", sfxSlider.value);

        PlayerPrefs.SetFloat("SFX Vol", sfxSlider.value);
    }

}
[System.Serializable]
public class ResItem
{
    public int horizontal, vertical; // this will just be a simple item that will allow us to reference it really easily and allow to see what's the horizontal value you want to use and vertical value 
}                                    // Asså i could just have writen a vector too but it's more fun to try new different things along the way and see different use cases different elemets in my opinion. 

