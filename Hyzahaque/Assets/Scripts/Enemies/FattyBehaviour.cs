using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FattyBehaviour : MonoBehaviour
{
    [SerializeField]
    private int Life = 6;

    [SerializeField]
    private int Speed = 50;

    
    private Vector2 Character_Position;
    private Vector3 Direction;
    private bool CanSeePlayer = false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = transform.parent.gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        SetCharacterPosition();
        Direction = new Vector3(Character_Position.x, Character_Position.y) - transform.position;
        CheckPlayer();
        if (CanSeePlayer)
            rb.velocity = Direction.normalized * Speed;
    }

    private void SetCharacterPosition()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");

        if (player.Length != 3)
            return;

        Character_Position = player[2].transform.position;
    }

    private void CheckPlayer()
    {

        //RaycastHit2D hit = Physics2D.Raycast(transform.position, Character_Position); 
        
        Ray2D ray = new Ray2D(transform.position, Direction.normalized);
        RaycastHit2D[] hits = Physics2D.RaycastAll(ray.origin, ray.direction);

        RaycastHit2D hit = hits[1];
        
        if (hit.collider.gameObject.tag == "Player")
            CanSeePlayer = true;
        else
        {
            CanSeePlayer = false;
        }
    }

    public void TakeDamages(int dmg)
    {
        Life -= dmg;

        if (Life <= 0)
            Destroy(transform.parent.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject go = collision.gameObject;
        if (go.tag == "Player")
            go.GetComponent<PlayerBehaviour>().TakeDamages(1);
    }
}
