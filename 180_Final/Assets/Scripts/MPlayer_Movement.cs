using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Mateo Jimenez
 * 12/5/2024
 * Handles player movement 
 */

public class MPlayer_Movement : MonoBehaviour
{

    public float moveSpeed;
    public float playerHeight;
    public float groundDrag;
    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    float horizontalInput;
    float verticalInput;

    public LayerMask groundCheck;

    bool isGrounded;
    bool readyToJump;

    public Transform orientation;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        readyToJump = true;

    }

    private void Update()
    {
        MyInput();

        //creates raycast to check if player touching ground
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * .5f +.2f, groundCheck);


        //sets drag if on ground or in air
        if (isGrounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 2;
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    //Player input for moving and jumping
    private void MyInput()
    {
        //wasd and arrow key input
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //if player preses space player will jump
        if (Input.GetKey(KeyCode.Space) && readyToJump && isGrounded)
        {
            readyToJump = false;
            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if (isGrounded) { 
        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        else if (!isGrounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }


    }

    //makes player jump, player can jump continously if space is held down
    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        
        
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);

    }

    private void ResetJump()
    {
        readyToJump = true;

    }
}
