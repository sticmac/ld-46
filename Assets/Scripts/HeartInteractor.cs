using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using NaughtyAttributes;

public class HeartInteractor : MonoBehaviour
{
    [Header("Player Components")]
    [SerializeField] ItemHolder _itemHolder;

    [Header("Parameters")]
    [SerializeField, Tag] string _heartTag;
    private bool _isNearHeart = false;

    public void Give(InputAction.CallbackContext context) {
        if (context.started && _isNearHeart) {
            _itemHolder.Flush();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        _isNearHeart = other.CompareTag(_heartTag);
    }

    private void OnTriggerExit2D(Collider2D other) {
        _isNearHeart = false;
    }
}
