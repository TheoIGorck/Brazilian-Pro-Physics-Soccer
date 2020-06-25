using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private MatchTime _matchTime = default;
    [SerializeField] private TimeUI _matchTimeCanvas = default;

    public void OnStart()
    {
        _matchTime.OnStart();
    }

    public void OnUpdate()
    {
        _matchTime.UpdateMatchTime();
        _matchTimeCanvas.UpdateTimeText(_matchTime.GetMinutes(), _matchTime.GetSeconds());
    }

    public bool CheckEndGame()
    {
        return _matchTime.CheckEndGame();
    }
}
