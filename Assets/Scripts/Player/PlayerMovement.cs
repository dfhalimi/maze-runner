using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    // we do not use the name "rigidbody" because in the component class of Rigidbody there already exists a member named "rigidbody"
    private Rigidbody _playerRigidbody;
    private Vector3 _movement;

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void HandleInput()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = 0f;
        _movement.z = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        _playerRigidbody.MovePosition(_playerRigidbody.position + _movement * _moveSpeed * Time.fixedDeltaTime);
    }
}
