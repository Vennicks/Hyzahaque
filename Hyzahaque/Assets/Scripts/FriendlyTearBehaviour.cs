using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FriendlyTearBehaviour : MonoBehaviour
{
    public float Speed = 0;
    public float Lifetime = 0;
    public Vector2 Direction = new Vector2();
    public int dmg = 1;

    Rigidbody2D rdb2;

    // Start is called before the first frame update
    void Awake()
    {
        rdb2 = GetComponent<Rigidbody2D>();
        StartCoroutine(KillItself());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rdb2.velocity = (Direction * Speed * Time.deltaTime);
    }

    IEnumerator KillItself()
    {
        yield return new WaitForSeconds(Lifetime);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;

        switch (go.tag)
        {
            case "Ennemy":
                Destroy(gameObject);
                if (go.name.Contains("Dip"))
                    go.GetComponent<DipBehaviour>().TakeDamages(dmg);

                else if (go.name.Contains("Fatty"))
                    go.GetComponent<FattyBehaviour>().TakeDamages(dmg);

                break;

            case "Walls":
                Destroy(gameObject);
                break;

            case "Rock":
                Destroy(gameObject);
                break;

            case "NormalDoor":
                Destroy(gameObject);
                break;

            case "HiddenDoor":
                Destroy(gameObject);
                break;

            case "UnbreakableDoor":
                Destroy(gameObject);
                break;

            case "Player":
                break;

            default:
                Destroy(gameObject);
                break;
        }

    }

}
