using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TimerUI timerUI = new();
    private bool _isStart = true;
    private int mouseButton = 0;
    private float _dealy = 0.5f;
    private int _stepTimer = 1;
    private int _time = 0;
    private Coroutine _timer;

    private void Start()
    {
        if (_timer != null)
            StopCoroutine(_timer);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(mouseButton))
        {
            if (_isStart)
            {
                _timer = StartCoroutine(Counter());
                _isStart = false;
            }
            else
            {
                if (_timer != null)
                    StopCoroutine(_timer);

                _isStart = true;
            }
        }
    }

    private IEnumerator Counter()
    {
        while (enabled)
        {
            _time += _stepTimer;
            timerUI.Draw(_time);

            yield return new WaitForSeconds(_dealy);
        }

    }
}
