using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementsController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 5f;
    [SerializeField] Rigidbody2D _rb2d = null;

    private Vector2 _deltaPosition;

    public void MoveAction(InputAction.CallbackContext context) {
        _deltaPosition = context.ReadValue<Vector2>() * _moveSpeed;
    }

    private void FixedUpdate() {
        _rb2d.position += _deltaPosition * Time.deltaTime;
    }

}
