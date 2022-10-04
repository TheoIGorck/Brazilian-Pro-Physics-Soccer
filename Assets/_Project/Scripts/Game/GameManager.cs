using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] 
    MultiplayerSystem _multiplayerSystem;
    [SerializeField] 
    private PositionsResetter _positionResetter = default;
    [SerializeField] 
    private TimeManager _timeManager = default;
    [SerializeField] 
    private ScoreManager _scoreManager = default;
    [SerializeField] 
    private BoostManager _boostManager = default;
    [SerializeField] 
    private AudioManager _audioManager = default;
    [SerializeField] 
    private ResultView _resultView = default;
    [SerializeField] 
    private Fade _fade = default;
    [SerializeField]
    private Ball _ball = default;

    private bool _hasGameEnded;

    private void Update()
    {
        if (_scoreManager.HasPlayerScored() && _scoreManager.CanScore) 
        {
            _audioManager.PlayGoalScream();
            _scoreManager.Scaler.ScaleScore(ShowCurrentScore);
            _timeManager.PauseTime();
            _scoreManager.CanScore = false;
        }
        
        if(_timeManager.IsMatchTimeOver() && !_hasGameEnded)
        {
            EndGame();
        }
    }

    private void ShowCurrentScore()
    {
        _fade.FadeAlpha(1, ResetGame);
    }

    private void ResetGame()
    {
        _scoreManager.Scaler.ResetScale();

        if(_scoreManager.HasPlayer1Scored())
        {
            _ball.ResetVelocity(Vector3.left);
        }
        else
        {
            _ball.ResetVelocity(Vector3.right);
        }

        _positionResetter.ResetToInitialPositions();
        _boostManager.Reset();
        _fade.FadeAlpha(0, _timeManager.ResumeTime);
        _scoreManager.ResetTriggers();
        _audioManager.PlayWhistleStart();
    }

    private void EndGame()
    {
        _resultView.Show(_scoreManager);
        _multiplayerSystem.enabled = false;
        _audioManager.PlayWhistleEnd();
        _audioManager.PlayVictory();
        _timeManager.PauseGame();
        _hasGameEnded = true;
    }
}
