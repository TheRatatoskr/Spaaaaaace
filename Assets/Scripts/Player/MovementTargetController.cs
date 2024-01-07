using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTargetController : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    [SerializeField] private InputReader _input;
    
    private Vector2 _joystickSpot;

    private void Start()
    {
        _input.MovementKeysChanged += UpdateJoystickLocation;
    }
    // Update is called once per frame
    void Update()
    {
        _target.transform.localPosition = new Vector3(_target.transform.localPosition.x, _joystickSpot.y);
    }

    private void UpdateJoystickLocation(Vector2 joystickLocation)
    {
        _joystickSpot = joystickLocation;
    }
}
