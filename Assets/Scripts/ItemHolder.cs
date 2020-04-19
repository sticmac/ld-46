using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class ItemHolder : MonoBehaviour
{
    [SerializeField] Transform _itemHolderTransform;
    [Range(0.1f,1f)]
    [SerializeField] float _marginBetweenHeldItems;

    [Header("Item Limit")]
    [SerializeField] bool _itemLimitEnabled = true;
    [SerializeField, ShowIf("_itemLimitEnabled")] int _itemLimit = 3;

    private Stack<Item> _itemList = new Stack<Item>();

    public void AddItem(Item item) {
        Transform itemTf = item.gameObject.transform;
        itemTf.SetParent(_itemHolderTransform); 
        itemTf.localPosition = Vector3.zero + _marginBetweenHeldItems * _itemList.Count * Vector3.up;
        _itemList.Push(item);
    }

    public bool CanAddItem(Item item) {
        if (!_itemLimitEnabled) {
            return !_itemList.Contains(item);
        } else {
            return _itemList.Count < _itemLimit && !_itemList.Contains(item);
        }
    }

    public bool Flush() {
        bool hasFlushedSomething = _itemList.Count > 0;
        while (_itemList.Count > 0) {
            Item item = _itemList.Pop();
            item.gameObject.SetActive(false);
        }
        return hasFlushedSomething;
    }
}
