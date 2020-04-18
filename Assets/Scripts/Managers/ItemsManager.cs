using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using NaughtyAttributes;

public class ItemsManager : MonoBehaviour
{
    public UnityEvent OnAllItemsUsed;

    [SerializeField] bool _addTimeWhenUsingItems;
    [SerializeField, ShowIf("_addTimeWhenUsingItems")] Timer _timer; // to increase the counter when items are used
    [SerializeField, ShowIf("_addTimeWhenUsingItems")] float _timeToAdd = 5f;

    private List<Item> _items = new List<Item>(); 

    public void AddItem(Item item) {
        _items.Add(item);
    }

    public void RemoveItem(Item item) {
        _items.Remove(item);

        if (_addTimeWhenUsingItems) {
            _timer.Add(_timeToAdd);
        }

        if (_items.Count == 0) {
            OnAllItemsUsed?.Invoke();
        }
    }
}
