using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PennyUIManager : MonoBehaviour
{

    [SerializeField] private TMP_Text pennyText;


    // Update is called once per frame
    void Update()
    {
        pennyText.text = PersistentManager.Instance.Coins.ToString();
    }
}