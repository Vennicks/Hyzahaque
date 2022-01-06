using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CacaBehaviour : MonoBehaviour
{
    int State = 0;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnDestroy()
    {
        State = 3;
        GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("State", State);
    }

    public void TakeDamage()
    {
        State += 1;
        if (State == 3)
            GetComponent<BoxCollider2D>().enabled = false;
    }


}
