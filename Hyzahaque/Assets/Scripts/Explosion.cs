using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public int damages = 2;
    public float lifetime= 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(KillItself());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;

        Debug.Log(go.tag);

        switch (go.tag)
        {
            case "Player":
                go.transform.parent.GetComponent<PlayerBehaviour>().TakeDamages(damages);
                break;

            case "Ennemy":
                if (go.name.Contains("Dip"))
                    go.GetComponent<DipBehaviour>().TakeDamages(20);

                else if (go.name.Contains("Fatty"))
                    go.GetComponent<FattyBehaviour>().TakeDamages(20);

                else if (go.name.Contains("Fly"))
                    go.GetComponent<FlyBehaviour>().TakeDamages(20);
                break;

            case "NormalDoor":
                Debug.Log("Openning door");
                go.GetComponent<NormalDoors>().Unlock();
                break;

            case "HiddenDoor":
                //go.GetComponent<HiddenDoors>().Unlock();
                break;

            case "TintedRock":
                //Break Tinted Rock
                break;

            case "Rock":
                go.GetComponent<NormalRock>().OnExplode();
                break;

            case "Poop":
                go.GetComponent<CacaBehaviour>().TakeDamage(2);
                break;

            case "Collectibles":
                Vector2 direction = new Vector2(go.transform.position.x - transform.position.x, go.transform.position.y - transform.position.y);
                go.GetComponent<Rigidbody2D>().AddForce(direction.normalized * 1000);

                break;
        }
    }

    IEnumerator KillItself()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
