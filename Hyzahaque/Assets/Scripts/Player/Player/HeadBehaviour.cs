using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeadBehaviour : MonoBehaviour
{
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


    // Start is called before the first frame update
    private InputMap inputMap;
    private Transform RightSpawn;
    private Transform LeftSpawn;

    private bool CanFire = true;
    private int EyeFiring = 1;

    [SerializeField] private float ShootingSpeed = 2f;
    [SerializeField] private GameObject Tear;
    [SerializeField] private float TearForce = 0.5f;
    [SerializeField] private float TearLifetime = 2f;

    private SHOOTINGDIRECTION PrimaryDirection = SHOOTINGDIRECTION.NONE;
    public SHOOTINGDIRECTION SecondDirection = SHOOTINGDIRECTION.DOWN;

    private bool FiringStatus = false;

    void Start()
    {
        inputMap = new InputMap();

        RightSpawn = transform.GetChild(0).transform;
        LeftSpawn = transform.GetChild(1).transform;

        inputMap.PlayerInput.Shooting.performed += Firing;
        inputMap.PlayerInput.Shooting.canceled += Cancel;
        inputMap.PlayerInput.Shooting.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (FiringStatus)
        {
            HandleFiring();
        }
        else
        {
            //Debug.Log("Not Firing, Direction: " + SystemDebug[(int)SecondDirection]);
        }
    }

    void Firing(InputAction.CallbackContext ctx)
    { 
        Vector2 ShootingDir = ctx.ReadValue<Vector2>();

        FiringStatus = true;

        if (ShootingDir.x != 0)
            PrimaryDirection = ShootingDir.x < 0 ? SHOOTINGDIRECTION.RIGHT : SHOOTINGDIRECTION.LEFT;

        if (ShootingDir.y != 0)
            PrimaryDirection = ShootingDir.y > 0 ? SHOOTINGDIRECTION.UP : SHOOTINGDIRECTION.DOWN;
    }

    void Cancel(InputAction.CallbackContext ctx)
    {
        PrimaryDirection = SHOOTINGDIRECTION.DOWN;
        FiringStatus = false;
    }

    private IEnumerator EnableFiring()
    {
        yield return new WaitForSeconds(ShootingSpeed);
        CanFire = true;
    }

    void HandleFiring()
    {
        if (!CanFire)
            return;

        Transform TearTransform = null;

        int Layer_Tear = GetComponent<SpriteRenderer>().sortingOrder;

        Vector2 Direc = new Vector2(0, 0);

        switch (PrimaryDirection) {
            case SHOOTINGDIRECTION.LEFT:
                TearTransform = LeftSpawn;

                if (EyeFiring == 1)
                    Layer_Tear -= 1;
                else
                    Layer_Tear += 1;

                Direc.x += TearForce;
                break;

            case SHOOTINGDIRECTION.RIGHT:
                TearTransform = RightSpawn;

                if (EyeFiring == 1)
                    Layer_Tear -= 1;
                else
                    Layer_Tear += 1;

                Direc.x -= TearForce;

                break;

            case SHOOTINGDIRECTION.UP:
                Layer_Tear -= 1;

                if (EyeFiring == 1)
                    TearTransform = RightSpawn;
                else
                    TearTransform = LeftSpawn;


                Direc.y += TearForce;
                break;

            case SHOOTINGDIRECTION.DOWN:
                Layer_Tear += 1;

                if (EyeFiring == 1)
                    TearTransform = RightSpawn;
                else
                    TearTransform = LeftSpawn;

                Direc.y -= TearForce;
                break;

            default:
                break;

            }

        GameObject NewTear = Tear;

        Tear.GetComponent<SpriteRenderer>().sortingOrder = Layer_Tear;
        Tear.GetComponent<FriendlyTearBehaviour>().Direction = Direc;
        Tear.GetComponent<FriendlyTearBehaviour>().Speed = TearForce;
        Tear.GetComponent<FriendlyTearBehaviour>().Lifetime = TearLifetime;

        Instantiate(NewTear, TearTransform.position, transform.localRotation);

        EyeFiring *= -1; //Invert crying eye

        CanFire = false;

        StartCoroutine(EnableFiring());
    }
}
