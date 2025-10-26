using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public event Action<int> OnTimeChanged;

    private bool _isRunning = false;
    private int mouseButton = 0;
    private float _dealy = 0.5f;
    private int _stepTimer = 1;
    private int _time = 0;
    private Coroutine _timer;

    private void Start()
    {
        if (_timer != null)
            StopCoroutine(_timer);

        ResetTimer();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(mouseButton))
        {
            if (_isRunning == false)
            {
                _timer = StartCoroutine(Counter());
                _isRunning = true;
            }
            else
            {
                if (_timer != null)
                    StopCoroutine(_timer);

                _isRunning = false;
            }
        }
    } 

    private IEnumerator Counter()
    {
        while (enabled)
        {
            _time += _stepTimer;
            OnTimeChanged?.Invoke(_time);

            yield return new WaitForSeconds(_dealy);
        }

    }
    public void ResetTimer()
    {
        _time = 0;
        OnTimeChanged?.Invoke(_time);
    }
}
