using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _textMeshPro;
    
    private float _dealy;

    private void Update()
    {
        
    }

    private IEnumerator PrintTimer()
    {
        _textMeshPro.text = "";
        yield return null;

    }

}
