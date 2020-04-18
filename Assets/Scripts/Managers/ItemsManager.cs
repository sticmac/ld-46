using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemsManager : MonoBehaviour
{
    public UnityEvent OnAllItemsUsed;

    private List<Item> _items = new List<Item>(); 

    public void AddItem(Item item) {
        _items.Add(item);
    }

    public void RemoveItem(Item item) {
        _items.Remove(item);

        if (_items.Count == 0) {
            OnAllItemsUsed?.Invoke();
        }
    }
}
