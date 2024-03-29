using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PickUpCollectible(GameObject obj)
    {
        if (obj.name.Contains("BlueHeart"))
        {
            PersistentManager.Instance.CurrentHealth += 2;
            Debug.Log("Add BlueHeart in UI");
            Destroy(obj);
        }
        if (obj.name.Contains("RedHeart"))
        {
            if (PersistentManager.Instance.CurrentHealth <= PersistentManager.Instance.MaxHealth - 2)
            {
                PersistentManager.Instance.CurrentHealth += 2;
                Debug.Log("Fill up 2 half of heart in UI");
                Destroy(obj);
            }
        }
        if (obj.name.Contains("SemiHeart"))
        {
            if (PersistentManager.Instance.CurrentHealth <= PersistentManager.Instance.MaxHealth - 1)
            {
                PersistentManager.Instance.CurrentHealth += 1;
                Debug.Log("Fill up a half of heart in UI");
                Destroy(obj);
            }
        }
        if (obj.name.Contains("BombItem") && obj.name != "ExplodingBomb")
        {
            PersistentManager.Instance.Bombs += 1;
            Debug.Log("Add a bomb in UI");
            Destroy(obj);
        }
        if (obj.name.Contains("Coin"))
        {
            PersistentManager.Instance.Coins += 1;
            Debug.Log("Add a coin in UI");
            Destroy(obj);
        }
        if (obj.name.Contains("Key"))
        {
            PersistentManager.Instance.Keys += 1;
            Debug.Log("Add a key in UI");
            Destroy(obj);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision == null)
            return;

        GameObject obj = collision.gameObject;

        switch (obj.tag)
        {
            case "Collectibles":
                PickUpCollectible(obj);
                break;

            case "BodyCharacters":
                break;

            case "Spikes":
                break;

            case "Item":
                transform.parent.GetComponent<PlayerBehaviour>().GotExplosiveBelt = true;
                break;

            default:
                break;
        }
    }

    public void TakeDamages(int i)
    {
        transform.parent.GetComponent<PlayerBehaviour>().TakeDamages(i);
    }
}
