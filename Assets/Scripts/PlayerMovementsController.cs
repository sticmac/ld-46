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
        Vector2 input = context.ReadValue<Vector2>();
        _deltaPosition = input * _moveSpeed;
        if (input != Vector2.zero) {
            float angle = Mathf.Atan2(-input.x, input.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    private void FixedUpdate() {
        _rb2d.position += _deltaPosition * Time.deltaTime;
    }

}
