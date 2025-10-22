using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TimerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textTimer;

    private float _dealy = 0.5f;
    private int _resetTimer = 0;
    private int _stepTimer = 1;

    private void Start()
    {
        _textTimer.text = _resetTimer.ToString();
    }

    public IEnumerator PrintTimer()
    {
        while (enabled)
        {
            int.TryParse(_textTimer.text, out int timer);
            
            timer += _stepTimer;
            _textTimer.text = timer.ToString();
         
            yield return new WaitForSeconds(_dealy);
        }

    }
}
