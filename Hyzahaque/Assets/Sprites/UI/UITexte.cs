using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITexte : MonoBehaviour
{
    public Animator myUIText;

    private bool triggered = false;
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
        if (!triggered && other.gameObject.tag == "Player")
        {
            triggered = true;
            myUIText.SetTrigger("Enter");
        }
        triggered = true;
    }
}
