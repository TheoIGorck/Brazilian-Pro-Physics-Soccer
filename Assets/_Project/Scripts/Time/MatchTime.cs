using UnityEngine;

public class MatchTime : MonoBehaviour
{
    [SerializeField]
    private float _startTime = 30f;
    
    private float _matchTime = 1;
    private float _gameStartTime = 0;
    private float _gameTime = 0;
    private string _minutes = "0";
    private string _seconds = "0";

    public void UpdateMatchTime(float stoppedTime)
    {
        if (_matchTime > 0)
        {
            _gameTime = (Time.time - stoppedTime) - _gameStartTime;
            _matchTime = _startTime - _gameTime;

            _minutes = ((int)_matchTime / 60).ToString("00");
            _seconds = (_matchTime % 60).ToString("00");
        }
    }

    public bool IsMatchTimeOver()
    {
        if(_matchTime <= 0)
        {
            return true;
        }

        return false;
    }

    private void Start()
    {
        _gameStartTime = Time.time;
    }

    public string Minutes { get => _minutes; }
    public string Seconds { get => _seconds; }
}
