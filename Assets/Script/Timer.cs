using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textTimer;

    private float _dealy = 0.5f;
    private int _resetTimer = 0;
    private int _stepTimer = 1;
    private bool _isStart = true;

    private void Start()
    {
        _textTimer.text = _resetTimer.ToString();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isStart)
                _isStart = false;
            else
                _isStart = true;
        }

        StartCoroutine(PrintTimer());
    }

    private IEnumerator PrintTimer()
    {
        int.TryParse(_textTimer.text, out int timer);

        yield return new WaitWhile(() => _isStart);

        yield return new WaitForSeconds(_dealy);

        timer += _stepTimer;
        _textTimer.text = timer.ToString();
    }

}
