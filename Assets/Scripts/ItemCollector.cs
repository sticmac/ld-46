using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using NaughtyAttributes;

public class ItemCollector : MonoBehaviour
{
    [Tag]
    [SerializeField] string _itemTag;
    [SerializeField] ItemHolder _itemHolder;
    [SerializeField] AudioSource _sfx;

    private void OnTriggerEnter2D(Collider2D other) {
        Item item = other.GetComponent<Item>();
        if (other.CompareTag(_itemTag) && _itemHolder.CanAddItem(item)) {
            _itemHolder.AddItem(item);
            if (_sfx) {
                _sfx.Play();
            }
        }
    }
}
