using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BombUIManager : MonoBehaviour
{

    [SerializeField] private TMP_Text bombText;


    // Update is called once per frame
    void Update()
    {
        bombText.text = PersistentManager.Instance.Bombs.ToString();
    }
}