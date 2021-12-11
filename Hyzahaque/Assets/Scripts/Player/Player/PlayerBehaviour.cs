using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    //InputManager
    private InputMap inputMap;
    private Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;

    private BodyBehaviour Body;
    private HeadBehaviour Head;

    //keep in memory the current movement performed
    private Vector2 currentMovement;

    //Serialized Field = things that can be edited easily
    [SerializeField] private float speed = 300;

    // Start is called before the first frame update
    void Start()
    {
        inputMap = new InputMap();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        inputMap.PlayerInput.Movement.performed += Moving;
        inputMap.PlayerInput.Movement.canceled += Moving;
        inputMap.PlayerInput.Movement.Enable();

        Head = transform.GetChild(0).gameObject.GetComponent<HeadBehaviour>();
        Body = transform.GetChild(1).gameObject.GetComponent<BodyBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentSpeed = currentMovement * Time.deltaTime * speed;

        rb2d.AddForce(currentSpeed);
    }

    void Moving(InputAction.CallbackContext ctx)
    {
        currentMovement = ctx.ReadValue<Vector2>();

        if (currentMovement.x != 0)
            Head.SecondDirection = currentMovement.x > 0 ? HeadBehaviour.SHOOTINGDIRECTION.RIGHT : HeadBehaviour.SHOOTINGDIRECTION.LEFT;
        else if (currentMovement.y != 0)
            Head.SecondDirection = currentMovement.y > 0 ? HeadBehaviour.SHOOTINGDIRECTION.UP : HeadBehaviour.SHOOTINGDIRECTION.DOWN;
        else
            Head.SecondDirection = HeadBehaviour.SHOOTINGDIRECTION.DOWN;
    }
}
