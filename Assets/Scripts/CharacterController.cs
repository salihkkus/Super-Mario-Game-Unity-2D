using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

[SerializeField] private float speed = 10f;
[SerializeField] private float jumpForge = 5f;

private Rigidbody2D _rigidbody2D;
private Animator _animator;

private bool grounded;
private bool started;
private void Awake()
{

_rigidbody2D = GetComponent<Rigidbody2D>(); //caching
_animator = GetComponent<Animator>(); //caching
started = true;

}

private void Update()
{

if(Input.GetKey("space"))
{
    Debug.Log("Jumping");
}

}

}
