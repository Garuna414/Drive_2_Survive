using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCarMovement : MonoBehaviour
{
    public float enginePower = 5f; // adjust this to control the car's engine power
    public float maxSpeed = 10f; // adjust this to control the car's maximum speed
    public float acceleration = 5f; // adjust this to control the car's acceleration
    public float deceleration = 10f; // adjust this to control the car's deceleration
    public float rotationSpeed = 3f; // adjust this to control the car's rotation speed
    public float gravityMultiplier = 2f; // adjust this to control the car's gravity multiplier
    public float groundCheckDistance = 0.1f; // adjust this to control the car's ground check distance
    public LayerMask groundMask; // set this to the layer mask for the ground objects

    private Rigidbody2D rb;
    private float currentSpeed = 0f;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // check for keyboard input to move the car
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (verticalInput > 0 && isGrounded) // if up arrow key is pressed and car is on the ground
        {
            // apply engine power to the car
            rb.AddForce(transform.up * enginePower);
        }
        else if (verticalInput < 0) // if down arrow key is pressed
        {
            // decelerate the car backward
            currentSpeed = Mathf.Clamp(currentSpeed - deceleration * Time.deltaTime, -maxSpeed, 0f);
        }
        else // if no arrow key is pressed
        {
            // decelerate the car gradually
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0f, deceleration * Time.deltaTime);
        }

        // rotate the car left or right based on keyboard input
        transform.Rotate(0f, 0f, -horizontalInput * rotationSpeed);

        // apply gravity to the car
        Vector2 gravity = new Vector2(0f, -Physics2D.gravity.magnitude * gravityMultiplier);
        rb.AddForce(gravity);

        // check if the car is on the ground
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, groundCheckDistance, groundMask);
        isGrounded = hit.collider != null;
    }

    void FixedUpdate()
    {
        // move the car forward based on current speed
        Vector2 movement = transform.up * currentSpeed;
        rb.MovePosition(rb.position + movement * Time.deltaTime);
    }
}

