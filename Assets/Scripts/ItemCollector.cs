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

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag(_itemTag)) {
            Debug.Log("Miaou");
            _itemHolder.AddItem(other.GetComponent<Item>());
        }
    }
}
