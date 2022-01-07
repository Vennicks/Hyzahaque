using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtsHeartVisual : MonoBehaviour
{
    [SerializeField] private Sprite heartSprite;

    private void start()
    {

    }
    private Image CreateHeartImage()
    {
        //Create Game Object
        GameObject heartGameObject = new GameObject("Heart",typeof(Image));
        //Set as child of this transform
        heartGameObject.transform.parent = transform;
        heartGameObject.transform.localPosition = Vector3.zero;
        //Set heart sprite
        Image heartImage = heartGameObject.GetComponent<Image>();
        heartImage.sprite = heartSprite;

        return heartImage;
    }
}
