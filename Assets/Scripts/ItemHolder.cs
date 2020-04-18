using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    [SerializeField] Transform _itemHolderTransform;
    [Range(0.1f,1f)]
    [SerializeField] float _marginBetweenHeldItems;
    private Stack<Item> _itemList = new Stack<Item>();

    public void AddItem(Item item) {
        Transform itemTf = item.gameObject.transform;
        itemTf.SetParent(_itemHolderTransform); 
        itemTf.localPosition = Vector3.zero + _marginBetweenHeldItems * _itemList.Count * Vector3.up;
        _itemList.Push(item);
    }

    public void Flush() {
    }
}
