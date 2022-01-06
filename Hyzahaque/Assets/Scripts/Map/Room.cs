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

    private void FirstTime()
    {
        FirstTimeEntered = false;
    }

    public void CheckLockDoors(int withXLess = 0)
    {
        if (FirstTimeEntered)
            FirstTime();

        Transform EnnemiesObject = transform.Find("Ennemies");
        Transform DoorsObject = transform.Find("Doors");

        Debug.Log("ChildCount: " + EnnemiesObject.childCount);
        if (EnnemiesObject.childCount - withXLess <= 0)
        {
            foreach (Transform child in DoorsObject.transform)
            {
                child.gameObject.GetComponent<NormalDoors>().Unlock();
            }
        } else
        {
            foreach (Transform child in DoorsObject.transform)
            {
                child.gameObject.GetComponent<NormalDoors>().Lock();
            }
        }
    }
}
