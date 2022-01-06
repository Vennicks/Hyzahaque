using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIKamikaze : MonoBehaviour
{
    public Animator myUIText;
    public bool token;
    // Start is called before the first frame update
    void Start()
    {
        token = false;
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && token == false)
        {
            myUIText.SetTrigger("Kami");
            token = true;
        }
    }
}
