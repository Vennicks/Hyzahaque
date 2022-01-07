using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalRock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

        Transform room = transform.parent.parent;

        Transform Coins = room.Find("Coins");
        if (Coins != null)
        {
            foreach (Transform child in Coins.transform)
            {
                child.gameObject.SetActive(true);
            }
        }

        Transform Hearts = room.Find("Heart");
        if (Hearts != null)
        {
            foreach (Transform child in Hearts.transform)
            {
                child.gameObject.SetActive(true);
            }
        }

        Transform Bombs = room.Find("Bombs");
        if (Hearts != null)
        {
            foreach (Transform child in Hearts.transform)
            {
                child.gameObject.SetActive(true);
            }
        }
    }
    
    public void OnExplode()
    {
        Destroy(gameObject);
    }
}
