using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchTime : MonoBehaviour
{
    private float _startTime = 120f;
    private float _matchTime = 1;
    private float _gameStartTime = 0;
    private float _gameTime = 0;
    private string minutes = "0";
    private string seconds = "0";

    public void OnStart()
    {
        _gameStartTime = Time.time;
    }

    public void UpdateMatchTime()
    {
        if (_matchTime > 0)
        {
            _gameTime = Time.time - _gameStartTime;
            _matchTime = _startTime - _gameTime;

            minutes = ((int)_matchTime / 60).ToString();
            seconds = (_matchTime % 60).ToString("f0");
        }
    }

    public bool CheckEndGame()
    {
        if(_matchTime <= 0)
        {
            return true;
        }

        return false;
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
