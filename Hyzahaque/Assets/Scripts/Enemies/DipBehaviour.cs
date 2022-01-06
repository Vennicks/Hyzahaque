using System.Collections;
using UnityEngine;

public class DipBehaviour : MonoBehaviour
{
    [SerializeField]
    private float CoolDownDash = 0.8f;

    [SerializeField]
    private float DashForce = 100;

    private Rigidbody2D rb;

    [SerializeField]
    private int Life = 2;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Dashing());

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Dashing()
    {
        Vector2 direction = Random.insideUnitCircle.normalized;
        if (direction == Vector2.zero)
            Dashing();

        yield return new WaitForSeconds(CoolDownDash);

        StartCoroutine(Dashing());
        StartCoroutine(StopDash());
        animator.SetBool("Dash", true);
        rb.AddForce(direction * DashForce);
    }

    IEnumerator StopDash()
    {
        yield return new WaitForSeconds(1.7f);
        animator.SetBool("Dash", false);
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        GameObject go = collider.gameObject;
        Debug.Log(go.name);

        if (go.tag == "Player")
        {
            go.GetComponent<PlayerBehaviour>().TakeDamages(1);
        }
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
