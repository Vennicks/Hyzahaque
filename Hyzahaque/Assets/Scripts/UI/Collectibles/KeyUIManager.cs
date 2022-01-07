using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyUIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text keyText;


    // Update is called once per frame
    void Update()
    { 
        //Debug.Log("key" + PersistentManager.Instance.name);
        keyText.text = PersistentManager.Instance.Keys.ToString();
    }
}
