using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(WinPlane.i++);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

}
