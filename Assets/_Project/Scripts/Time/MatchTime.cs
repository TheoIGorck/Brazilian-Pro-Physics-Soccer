using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchTime : MonoBehaviour
{
    private float _startTime = 120f;
    private float _matchTime = 1;
    private string minutes = "0";
    private string seconds = "0";

    public void UpdateMatchTime()
    {
        if (_matchTime > 0)
        {
            _matchTime = _startTime - Time.time;

            minutes = ((int)_matchTime / 60).ToString();
            seconds = (_matchTime % 60).ToString("f0");
        }
    }

    public string GetMinutes()
    {
        return minutes;
    }

    public string GetSeconds()
    {
        return seconds;
    }
}
