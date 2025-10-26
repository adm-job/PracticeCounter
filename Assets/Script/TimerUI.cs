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
    [SerializeField] private Timer _timer;

    private void OnEnable()
    {
        _timer.OnTimeChanged += Draw;
    }

    private void OnDisable()
    {
        _timer.OnTimeChanged -= Draw;
    }

    public void Draw(int number)
    {
        _textTimer.text = Convert.ToString(number);
    }


}
