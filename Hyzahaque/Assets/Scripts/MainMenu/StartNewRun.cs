using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNewRun : MonoBehaviour
{
    public string newRunSelect;

    public GameObject charSelectWindow;
    public GameObject mainMenuWindow;

    public void NewRun()
    {
        SceneManager.LoadScene(newRunSelect);
        Debug.Log("Level1 loaded");
    }

    public void CloseCharSelect()
    {

        charSelectWindow.SetActive(false);
        Debug.Log("charSelect closed");

    }

    public void openMainMenuWindow()
    {
        mainMenuWindow.SetActive(true);
        Debug.Log("oui");
    }

}
