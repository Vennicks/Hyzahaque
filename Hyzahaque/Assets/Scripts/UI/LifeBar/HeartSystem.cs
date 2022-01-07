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
        switch (life)
        {
            case 1:
                Destroy(hearts[0].gameObject);
                break;
            case 2:
                Destroy(hearts[1].gameObject);
                break;
            case 3:
                Destroy(hearts[2].gameObject);
                break;
            case 4:
                Destroy(hearts[3].gameObject);
                break;
            case 5:
                Destroy(hearts[4].gameObject);
                break;
            case 6:
                Destroy(hearts[5].gameObject);
                break;
            default:
                break;
        }

    }

    public void TakeDamage(int d)
    {
        life -= d;
        Destroy(hearts[life].gameObject);
        if(life < 1)
        {
            isDead = true;
        }
    }
}
