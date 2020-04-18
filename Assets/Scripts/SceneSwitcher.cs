using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] Scene[] scenes;

    private int _currentScene = 0;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void LoadNextScene() {
        SceneManager.LoadScene(++_currentScene);
    }
}
