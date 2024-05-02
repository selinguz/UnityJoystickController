using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private float _moveSpeed;

    void Start()
    {
    }
    private void FixedUpdate()
    {
        JoystickMovement();
    }

    void JoystickMovement()
    {
        float horizontal = _joystick.Horizontal;
        float vertical = _joystick.Vertical;
        Vector3 addedPosition = new Vector3(horizontal * _moveSpeed * Time.deltaTime, 0, vertical * _moveSpeed * Time.deltaTime);
        transform.position += addedPosition;
    }
}
