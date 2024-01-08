using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _turnSpeed;

    private Vector2 _cursorPosition;

    [SerializeField] private Transform _targetPosition;

    [SerializeField] private InputReader _reader;

    [SerializeField] private float _upTilt;
    [SerializeField] private float _turnTilt;

    private Vector2 _joystickPosition;

    private void Start()
    {
        _reader.MovementKeysChanged += HandStickMotion;
    }

    private void Update()
    {
        DoMovement();
    }

    private void DoMovement()
    {
        //transform.LookAt(_targetPosition);

        transform.rotation = Quaternion.Slerp(
            transform.rotation, 
            Quaternion.Euler(
                _joystickPosition.y * _upTilt,
                _joystickPosition.x * _turnTilt, 
                transform.rotation.z),
            _turnSpeed * Time.deltaTime);

        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }

    private void HandStickMotion(Vector2 joystick)
    {
        _joystickPosition = joystick;
    }
}
