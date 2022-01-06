using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBehaviour : MonoBehaviour
{
    [SerializeField]
    private float Speed = 5;

    [SerializeField]
    private int Life = 2;

    private Vector3 Direction;
    private Vector2 Character_Position;

    private Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        SetCharacterPosition();
        Direction = new Vector3(Character_Position.x, Character_Position.y) - transform.position;
        
        rb.velocity = Direction.normalized * Speed;
    }


    private void SetCharacterPosition()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");

        if (player.Length != 3)
            return;

        Character_Position = player[1].transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject go = collider.gameObject;

        if (go.tag == "Player")
            go.transform.parent.GetComponent<PlayerBehaviour>().TakeDamages(1);
    }

    public void TakeDamages(int dmg)
    {
        Life -= dmg;

        if (Life <= 0)
        {
            transform.parent.parent.GetComponent<Room>().CheckLockDoors(1);
            Destroy(gameObject);
        }
    }

}
