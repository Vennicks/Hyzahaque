using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FriendlyTearBehaviour : MonoBehaviour
{
    [System.NonSerialized]
    public float Speed = 0;
    [System.NonSerialized]
    public float Lifetime = 0;

    [System.NonSerialized]
    public Vector2 Direction = new Vector2();

    Rigidbody2D rdb2;

    // Start is called before the first frame update
    void Awake()
    {
        rdb2 = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rdb2.velocity = (Direction * Speed * Time.deltaTime);
    }
}
