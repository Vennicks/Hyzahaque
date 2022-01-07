using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManager : MonoBehaviour {
    public static PersistentManager Instance { get; private set;}

    public int MaxHealth = 6;

    public int CurrentHealth = 6;

    public int Coins = 0;
    public int Bombs = 0;
    public int Keys = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
}
