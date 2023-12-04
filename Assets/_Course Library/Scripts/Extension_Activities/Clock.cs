using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    //Get a ref to hand gameObjects
    [SerializeField] private Transform HourHand;
    [SerializeField] private Transform MinuteHand;
    [SerializeField] private Transform SecondHand;

    private int _currentHour;
    private int _currentMinute;
    private int _currentSecond;

    // Update is called once per frame
    void Update()
    {
        SetTimeHour();
        SetTimeMinute();
        SetTimeSecond();
    }

    //Set the x rotation of the hands
    void SetTimeHour()
    {
        var currentTime = DateTime.Now;
        var hour = currentTime.Hour;

        if (hour == _currentHour) return;

        _currentHour = hour;

        float angle = 30 * (hour % 12) + 90;

        Quaternion rotation =
        Quaternion.Euler(angle, 0, -90);

        HourHand.localRotation = rotation;
    }

    void SetTimeMinute()
    {
        var currentTime = DateTime.Now;
        var min = currentTime.Minute;

        if (min == _currentMinute) return;

        _currentMinute = min;

        float angle = 6 * (min % 60) + 90;

        Quaternion rotation =
        Quaternion.Euler(angle, 0, -90);

        MinuteHand.localRotation = rotation;
    }

    void SetTimeSecond()
    {
        var currentTime = DateTime.Now;
        var sec = currentTime.Second;

        if (sec == _currentSecond) return;

        _currentSecond = sec;

        float angle = 6 * (sec % 60) + 90;

        Quaternion rotation =
        Quaternion.Euler(angle, 0, -90);

        SecondHand.localRotation = rotation;
    }
}
