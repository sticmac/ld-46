using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSTPlayer : MonoBehaviour
{
    private void Awake() {
        if (FindObjectsOfType(typeof(OSTPlayer)).Length > 1) {
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        }
    }
}
