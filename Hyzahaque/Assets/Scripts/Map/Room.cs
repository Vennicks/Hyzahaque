using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    // Start is called before the first frame update

    private bool FirstTimeEntered = true; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FirstTime(int withless = 0)
    {
        FirstTimeEntered = false;

        Transform EnnemiesObject = transform.Find("Ennemies");

        foreach (Transform child in EnnemiesObject.transform)
        {
            child.gameObject.SetActive(true);
        }

        if (EnnemiesObject.transform.childCount - withless > 0)
            return;

        Transform Coins = transform.Find("Coins");
        if (Coins != null)
        {
            foreach (Transform child in Coins.transform)
            {
                child.gameObject.SetActive(true);
            }
        }

        Transform Hearts = transform.Find("Heart");
        if (Hearts != null)
        {
            foreach (Transform child in Hearts.transform)
            {
                child.gameObject.SetActive(true);
            }
        }
        Transform Bomb = transform.Find("Bombs");
        if (Bomb != null)
        {
            foreach (Transform child in Bomb.transform)
            {
                child.gameObject.SetActive(true);
            }
        }

    }

    public void CheckLockDoors(int withXLess = 0)
    {
        Transform EnnemiesObject = transform.Find("Ennemies");
        Transform DoorsObject = transform.Find("Doors");

       if (FirstTimeEntered) 
            FirstTime();

        //Debug.Log("ChildCount: " + EnnemiesObject.childCount);
        if (EnnemiesObject.childCount - withXLess > 0)
        {
            foreach (Transform child in DoorsObject.transform)
            {
                child.gameObject.GetComponent<NormalDoors>().Lock();
            }
        } else
        {
            foreach (Transform child in DoorsObject.transform)
            {
                child.gameObject.GetComponent<NormalDoors>().Unlock();
            }
            FirstTime(withXLess);
        }
    }
}
