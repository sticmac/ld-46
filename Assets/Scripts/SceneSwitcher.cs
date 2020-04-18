using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private int _currentScene = 0;

    private void Awake() {
        _currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadNextScene() {
        SceneManager.LoadScene(_currentScene + 1);
    }
}
