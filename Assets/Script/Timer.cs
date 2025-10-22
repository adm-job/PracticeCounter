using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TimerUI timerUI = new();
    private bool _isStart = true;
    private int mouseButton = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(mouseButton))
        {
            if (_isStart)
            {
                StartCoroutine(timerUI.PrintTimer());
                _isStart = false;
            }
            else
            {
                StopCoroutine(timerUI.PrintTimer());
                _isStart = true;
            }
        }
    }
}
