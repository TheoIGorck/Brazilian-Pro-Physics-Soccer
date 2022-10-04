using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] 
    private MatchTime _matchTime = default;
    [SerializeField] 
    private TimeUI _timeUI = default;

    private bool _isUpdatingTime = true;
    private float _stoppedTime;

    public void Update()
    {
        if(_isUpdatingTime)
        {
            _matchTime.UpdateMatchTime(_stoppedTime);
            _timeUI.UpdateText(_matchTime.Minutes, _matchTime.Seconds);
        }
        else
        {
            _stoppedTime += Time.deltaTime;
        }
    }

    public void PauseTime()
    {
        _isUpdatingTime = false;
    }

    public void ResumeTime()
    {
        _isUpdatingTime = true;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public bool IsMatchTimeOver()
    {
        return _matchTime.IsMatchTimeOver();
    }
}
