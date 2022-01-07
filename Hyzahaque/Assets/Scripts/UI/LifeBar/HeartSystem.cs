using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;

    private bool isDead;


    private void Start()
    {
        life = hearts.Length;
    }



    // Update is called once per frame
    void Update()
    {        

    }



    public void TakeDamage(int d)
    {
        int lifeCopy = life;
        for (int i = 0; i != d; i++)
        {
            hearts[life - i - 1].gameObject.SetActive(false);
            life--;
        }

        life = lifeCopy - d;
    }

    public void GetLife(int d)
    {
        int lifeCopy = life;
        for (int i = 0; i != d; i++)
        {
            hearts[life + i - 1].gameObject.SetActive(true);
            life++;
        }
        life = lifeCopy + d;
    }
}
