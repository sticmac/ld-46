using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class Timer : MonoBehaviour
{
    public UnityEvent OnTimerFinished;

    [Header("UI")]
    [SerializeField] Text _timerUIText;

    [Header("Parameters")]
    [SerializeField] float _initialTime = 0f; 

    private float _timeRemaining;
    private bool _running = false;

    public float TimeRemaining => _timeRemaining;

    public void ResetAndRun() {
        Reset();
        Run();
    }

    public void Reset() {
        _timeRemaining = _initialTime;
        DisplayTime(_timeRemaining);
    }

    public void Run() {
        _running = true;
    }

    public void Pause() {
        _running = false;
    }

    public void Add(float addValue) {
        _timeRemaining += addValue;
    }

    private void Start() {
        ResetAndRun();
    }

    void Update() {
        if (_running) {
            if (_timeRemaining > 0) {
                _timeRemaining -= Time.deltaTime;
            } else {
                _timeRemaining = 0;
                OnTimerFinished?.Invoke();
            }
        }
        DisplayTime(_timeRemaining);
    }

    void DisplayTime(float time) {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        _timerUIText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
