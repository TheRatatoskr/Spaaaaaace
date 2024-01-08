using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMotionController : MonoBehaviour
{
    [SerializeField] private InputReader _input;
    [SerializeField] private GameObject _shipModel;

    private float _currentTiltAngle;

    [SerializeField] private float _maxTiltAngle;

    [SerializeField] private float _tiltSpeed;

    private void Start()
    {
        _input.MovementKeysChanged += HandleTurning;
    }

    private void Update()
    {
        transform.localPosition = Vector3.zero;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x,transform.rotation.y, _currentTiltAngle), _tiltSpeed * Time.deltaTime);
    }

    private void HandleTurning(Vector2 joystickInput)
    {
        _currentTiltAngle = joystickInput.x * _maxTiltAngle * -1;
        _currentTiltAngle = Mathf.Clamp(_currentTiltAngle, -45, 45);
    }

}
