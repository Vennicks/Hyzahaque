using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject optionWindow;
    public GameObject charSelectWindow;
    public GameObject mainMenuWindow;



    public void Options()
    {
        optionWindow.SetActive(true);
        Debug.Log("options opened");       
    }


    public void charSelect()
    {
        charSelectWindow.SetActive(true);
        Debug.Log("char select opened");       
    }


    public void CloseMainMenu()
    {
        mainMenuWindow.SetActive(false);
        Debug.Log("main menu closed");
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
