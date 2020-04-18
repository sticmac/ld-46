using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementsController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 5f;

    private Vector2 _deltaPosition;

    public void MoveAction(InputAction.CallbackContext context) {
        _deltaPosition = context.ReadValue<Vector2>() * _moveSpeed;
    }

    private void FixedUpdate() {
        transform.position += (Vector3)_deltaPosition * Time.deltaTime;
    }

}
