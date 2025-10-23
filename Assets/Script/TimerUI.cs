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

    private int _resetTimer = 0;

    private void Start()
    {
        _textTimer.text = _resetTimer.ToString();
    }

    public void Draw(int number)
    {
        _textTimer.text = Convert.ToString(number);
    }


}
