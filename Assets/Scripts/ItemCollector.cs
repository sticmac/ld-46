using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using NaughtyAttributes;

public class ItemCollector : MonoBehaviour
{

    public UnityEvent OnAllItemsCollected;

    [Tag]
    [SerializeField] string _itemTag;

    [SerializeField] int _maxToCollect = 1;

    private int _collected = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag(_itemTag)) {
            Destroy(other.gameObject);
            _collected++;
            if (_collected == _maxToCollect) {
                OnAllItemsCollected?.Invoke();
            }
        }
    }
}
