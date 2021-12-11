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
    }
}
