using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _textTimer;
    
    private float _dealy = 0.5f;
    private float _startTikmer = 0;

    private void Start()
    {
        _textTimer.text = _startTikmer.ToString();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            PrintTimer();
        }
    }

    private IEnumerator PrintTimer()
    {
        _textTimer.text = "12334";
        yield return null;

    }

}
