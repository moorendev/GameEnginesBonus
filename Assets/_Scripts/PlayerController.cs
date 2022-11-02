using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerAction inputAction;
    float move;
    Rigidbody rb;

    private float distanceToGround;
    bool isGrounded = true;
    public float jump = 5f;
    public float walkSpeed = 5f;

    private bool isWalking = false;

    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }

    private void Awake()
    {
        inputAction = new PlayerAction();

        inputAction.Player.Jump.performed += cntxt => Jump();

        inputAction.Player.Move.performed += cntxt => move = cntxt.ReadValue<float>();
        inputAction.Player.Move.canceled += cntxt => move = 0;

        rb = GetComponent<Rigidbody>();

        distanceToGround = GetComponent<Collider>().bounds.extents.y + 0.35f;
    }

    private void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * move * walkSpeed, Space.Self);

        isGrounded = Physics.Raycast(transform.position, -Vector3.up, distanceToGround);
    }
}

