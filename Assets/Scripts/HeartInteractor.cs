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

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag(_heartTag)) {
            _itemHolder.Flush();
        }
    }
}
