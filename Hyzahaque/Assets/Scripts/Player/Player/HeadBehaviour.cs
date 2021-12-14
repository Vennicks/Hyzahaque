using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeadBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private InputMap inputMap;
    private Transform LeftSpawn;
    private Transform RightSpawn;

    public enum SHOOTINGDIRECTION
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
        NONE
    }

    private List<string> SystemDebug = new List<string>()
    {
        "UP",
        "DOWN",
        "LEFT",
        "RIGHT"
    };

    [SerializeField] private float ShootingSpeed = 100;

    private SHOOTINGDIRECTION PrimaryDirection = SHOOTINGDIRECTION.NONE;
    public SHOOTINGDIRECTION SecondDirection = SHOOTINGDIRECTION.DOWN;

    private bool FiringStatus = false;

    void Start()
    {
        inputMap = new InputMap();

        LeftSpawn = transform.GetChild(0).transform;
        RightSpawn = transform.GetChild(1).transform;

        inputMap.PlayerInput.Shooting.performed += Firing;
        inputMap.PlayerInput.Shooting.canceled += Cancel;
        inputMap.PlayerInput.Shooting.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (FiringStatus)
        {
            Debug.Log("Firing, Direction: " + SystemDebug[(int)PrimaryDirection]);
        }
        else
        {
            Debug.Log("Not Firing, Direction: " + SystemDebug[(int)SecondDirection]);
        }
    }

    void Firing(InputAction.CallbackContext ctx)
    { 
        Vector2 ShootingDir = ctx.ReadValue<Vector2>();

        FiringStatus = true;

        if (ShootingDir.x != 0)
            PrimaryDirection = ShootingDir.x > 0 ? SHOOTINGDIRECTION.RIGHT : SHOOTINGDIRECTION.LEFT;

        if (ShootingDir.y != 0)
            PrimaryDirection = ShootingDir.y > 0 ? SHOOTINGDIRECTION.UP : SHOOTINGDIRECTION.DOWN;
    }

    void Cancel(InputAction.CallbackContext ctx)
    {
        PrimaryDirection = SHOOTINGDIRECTION.DOWN;
        FiringStatus = false;
    }
}
