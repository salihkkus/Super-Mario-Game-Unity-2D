using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContoller : MonoBehaviour
{
    [SerializeField] private float speed = 4f; // Character movement speed
    [SerializeField] private float jumpForce = 300f; // Jump force applied to the character
    private Rigidbody2D _rigidbody2D; // Rigidbody2D component reference
    private Animator _animator; // Animator component reference

    private bool grounded; // Checks if the character is on the ground
    private bool started; // Checks if the game has started
    private bool jumping; // Checks if the character is jumping

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>(); // Cache Rigidbody2D component
        _animator = GetComponent<Animator>(); // Cache Animator component
        grounded = true; // Set the character as grounded initially
    }

    private void Update()
    {
        if (Input.GetKeyDown("space")) // Check if the space key is pressed
        {
            if (started && grounded) // If the game has started and the character is on the ground
            {
                _animator.SetTrigger("Jump"); // Trigger the jump animation
                grounded = false; // Set grounded to false
                jumping = true; // Set jumping to true
            }
            else
            {
                _animator.SetBool("GameStarted", true); // Set animation parameter to start the game
                started = true; // Mark the game as started
            }
        }

        _animator.SetBool("Grounded", grounded); // Update the animator grounded state
    }

    private void FixedUpdate()
    {
        if (started) // If the game has started
        {
            _rigidbody2D.velocity = new Vector2(speed, _rigidbody2D.velocity.y); // Move the character forward
        }

        if (jumping) // If the character is jumping
        {
            _rigidbody2D.AddForce(new Vector2(0f, jumpForce)); // Apply vertical force for jumping
            jumping = false; // Reset jumping state after applying force
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground")) // Check if the character collides with the ground
        {
            grounded = true; // Set the character as grounded
        }
    }
}
