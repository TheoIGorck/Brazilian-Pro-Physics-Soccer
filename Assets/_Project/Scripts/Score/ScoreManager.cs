using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] 
    private Score[] _scores = default;
    [SerializeField] 
    private ScoreTrigger[] _scoreTriggers = default;
    [SerializeField] 
    private MatchScoreScaler _matchScoreScaler;

    public void ResetTriggers()
    {
        _scoreTriggers[0].IsActive = true;
        _scoreTriggers[1].IsActive = true;
        CanScore = true;
    }

    public bool IsADraw()
    {
        return _scores[0].ScoreAmount == _scores[1].ScoreAmount;
    }

    public bool IsPlayer1Winner()
    {
        return _scores[0].ScoreAmount > _scores[1].ScoreAmount;
    }

    public bool HasPlayerScored()
    {
        return !_scoreTriggers[0].IsActive || !_scoreTriggers[1].IsActive;
    }

    public bool HasPlayer1Scored()
    {
        return !_scoreTriggers[1].IsActive;
    }

    private void Start()
    {
        CanScore = true;
    }

    public MatchScoreScaler Scaler { get => _matchScoreScaler; }
    public bool CanScore { get; set; }
}
