using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class ItemCollector : MonoBehaviour
{
    [Tag]
    [SerializeField] string _itemTag;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag(_itemTag)) {
            Destroy(other.gameObject);
        }
    }
}
