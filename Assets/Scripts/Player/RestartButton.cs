using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void Restart() //funktion som restartar - Robin
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reloadar scenen - Robin
    }
}
