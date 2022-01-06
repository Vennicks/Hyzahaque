using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITexte : MonoBehaviour
{
    public Animator myUIText;
    // Start is called before the first frame update
    void Start()
    {
        myUIText.SetTrigger("Enter");
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            myUIText.SetTrigger("Enter");
        }
    }
}
