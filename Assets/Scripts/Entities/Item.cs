using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Item : MonoBehaviour
{
    private ItemsManager _m = null;
    private ItemsManager _manager {
        get {
            if (_m == null) {
                _m = FindObjectOfType<ItemsManager>();
                if (_m == null) Debug.LogError("Items Manager not found!");
            }
            return _m;
        }
    }

    private void OnEnable() {
        _manager.AddItem(this);
    }
    private void OnDisable() {
        _manager.RemoveItem(this);
    }
}
