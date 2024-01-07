using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Vector2 _cursorPosition;

    [SerializeField] private Transform _targetPosition;

    [SerializeField] private InputReader _reader;

    private void Start()
    {
        
    }

    private void Update()
    {
        DoMovement();
    }

    private void DoMovement()
    {
        transform.LookAt(_targetPosition);

        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
