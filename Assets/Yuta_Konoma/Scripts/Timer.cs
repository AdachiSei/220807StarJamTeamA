using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour 
{
    [SerializeField] TextMeshProUGUI _timeText;

    private int _minute;
    private float _seconds;

    public  static float _time;

    private void Start()
    {
        _timeText.text = "Time:" + _time;
    }

    void Update()
    {
        _time+= Time.deltaTime ;

        _seconds += Time.deltaTime;

        if(_seconds > 60f)
        {
            _minute += 1;
            _seconds = 0;
        }
        _timeText.text = _minute.ToString("Time:0") + ":" + _seconds.ToString("f2");
    }
}
