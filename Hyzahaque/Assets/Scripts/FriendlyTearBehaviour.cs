using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FriendlyTearBehaviour : MonoBehaviour
{
    public float Speed = 0;
    public float Lifetime = 2f;
    public Vector2 Direction = new Vector2();
    public int dmg = 1;
    public Animator animator;
    Rigidbody2D rdb2;
    
    bool stop = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rdb2 = GetComponent<Rigidbody2D>();
        StartCoroutine(KillItself());
    }

    void OnDestroy()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log("Speed:" + Speed + " - Lifetime: " + Lifetime + " - Velocity: " + rdb2.velocity + " - Direction: " + Direction);
        if (!stop)
            rdb2.velocity = (Direction * Speed * Time.deltaTime);
        else
            rdb2.velocity = Vector2.zero;
    }

    IEnumerator KillItself()
    {
        yield return new WaitForSeconds(Lifetime);
        Speed = 0;
        GetComponent<CircleCollider2D>().enabled = false;
        animator.SetTrigger("Destroy");
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }

    IEnumerator Collision()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;
        GetComponent<CircleCollider2D>().enabled = false;
        //Debug.Log(go.tag);
        switch (go.tag)
        {
            case "Ennemy":
                Vector2 vec = collision.transform.position - transform.position;
                if (go.name.Contains("Dip"))
                {
                    go.GetComponent<DipBehaviour>().TakeDamages(dmg);
                    go.GetComponent<Rigidbody2D>().drag = 30;
                    go.GetComponent<Rigidbody2D>().AddForce(Direction.normalized * 17, ForceMode2D.Impulse);
                }
                else if (go.name.Contains("Fatty"))
                {
                    go.GetComponent<FattyBehaviour>().TakeDamages(dmg);
                    go.transform.parent.GetComponent<Rigidbody2D>().AddForce(Direction.normalized * 17, ForceMode2D.Impulse);
                } else if (go.name.Contains("Fly"))
                {
                    go.GetComponent<FlyBehaviour>().TakeDamages(dmg);
                }



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

            case "Poop":
                animator.SetTrigger("Destroy");
                stop = true;
                go.GetComponent<CacaBehaviour>().TakeDamage();
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
