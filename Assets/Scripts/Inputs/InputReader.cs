using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static PlayerInput;
using System;

[CreateAssetMenu(fileName = "New Input Reader", menuName = "Input/Input Reader")]
public class InputReader : ScriptableObject, IShipControlsActions
{
    private PlayerInput input;

    public event Action<Vector2> MovementKeysChanged;

    private void OnEnable()
    {
        if (input == null)
        {
            input = new PlayerInput();
            input.ShipControls.SetCallbacks(this);
        }
        input.ShipControls.Enable();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        MovementKeysChanged?.Invoke(context.ReadValue<Vector2>());
    }


}
