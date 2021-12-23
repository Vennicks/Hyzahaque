using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingBomb : MonoBehaviour
{
    [SerializeField]
    private GameObject xxplosion;

    [SerializeField]
    private float TimeBeforeExplosion = 3;

    // Start is called before the first frame update
    void Start()
    {
        xxplosion.GetComponent<Explosion>().damages = 2;
        StartCoroutine(Explode());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Explode()
    {
        yield return new WaitForSeconds(TimeBeforeExplosion);
        Instantiate(xxplosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
