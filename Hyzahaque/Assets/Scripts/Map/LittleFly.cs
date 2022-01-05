using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleFly : MonoBehaviour
{
    public Animator flyAnim;
    // Start is called before the first frame update
    void Start()
    {
        //flyAnim = GetComponent<Animator>;
    }

    // Update is called once per frame
    public void RandomizeAnimation()
    {
        float speed = Random.Range(0.5f, 1.5f);
        flyAnim.speed = speed;
    }
}
