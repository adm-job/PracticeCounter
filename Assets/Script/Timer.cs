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

    private double _dealy = 0.5;
    private double _startTimer = 0;

    private void Start()
    {
        _textTimer.text = _startTimer.ToString();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(PrintTimer());
        }
    }

    private IEnumerator PrintTimer()
    {
        double timer = Convert.ToDouble(_textTimer.text);
        bool isStart = false;

        /*        if (Input.GetMouseButtonDown(0) || isStart)
                    isStart = false;
                else
                    isStart = true;*/

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        isStart = true;
        while (isStart)
        {

            timer += _dealy;
            _textTimer.text = timer.ToString();
        if (Input.GetMouseButtonDown(0)) 
                isStart = false;
        }

    }

}
