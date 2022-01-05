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
    public Animator animator;
    Rigidbody2D rdb2;
    bool stop = false;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
        rdb2 = GetComponent<Rigidbody2D>();
        StartCoroutine(KillItself());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!stop)
            rdb2.velocity = (Direction * Speed * Time.deltaTime);
        else
            rdb2.velocity = Vector2.zero;
    }

    IEnumerator KillItself()
    {
        yield return new WaitForSeconds(Lifetime);
        Speed = 0;
        animator.SetTrigger("Destroy");
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    IEnumerator Collision()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;

        switch (go.tag)
        {
            case "Ennemy":
                if (go.name.Contains("Dip"))
                    go.GetComponent<DipBehaviour>().TakeDamages(dmg);

                else if (go.name.Contains("Fatty"))
                    go.GetComponent<FattyBehaviour>().TakeDamages(dmg);

                animator.SetTrigger("Destroy");
                stop = true;
                StartCoroutine(Collision());

                break;

            case "Walls":
                animator.SetTrigger("Destroy");
                stop = true;
                StartCoroutine(Collision());
                break;

            case "Rock":
                animator.SetTrigger("Destroy");
                stop = true;
                StartCoroutine(Collision());
                break;

            case "NormalDoor":
                animator.SetTrigger("Destroy");
                stop = true;
                StartCoroutine(Collision());
                break;

            case "HiddenDoor":
                animator.SetTrigger("Destroy");
                stop = true;
                StartCoroutine(Collision());
                break;

            case "UnbreakableDoor":
                animator.SetTrigger("Destroy");
                stop = true;
                StartCoroutine(Collision());
                break;

            case "Player":
                break;

            default:
                animator.SetTrigger("Destroy");
                stop = true;
                StartCoroutine(Collision());
                break;
        }
    }

}
