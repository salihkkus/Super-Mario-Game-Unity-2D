using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

[SerializeField] private float speed = 10f;
[SerializeField] private float jumpForce = 5f;

private Rigidbody2D _rigidbody2D;
private Animator _animator;

private bool grounded;
private bool started;
private bool jumping;
private void Awake()
{

_rigidbody2D = GetComponent<Rigidbody2D>(); //caching
_animator = GetComponent<Animator>(); //caching
grounded = true;

}

private void Update()
{

if(Input.GetKeyDown("space"))
{
    
}

}

private void FixedUpdate()
{
    if(started)
    {
    _rigidbody2D.velocity = new Vector2(speed, _rigidbody2D.velocity.y);
    }

    if(jumping)
    {
        _rigidbody2D.AddForce(new Vector2(0f,jumpForce));
    }
}


}
