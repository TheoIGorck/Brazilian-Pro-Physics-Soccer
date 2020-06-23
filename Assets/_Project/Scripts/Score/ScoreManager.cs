using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Score _score = default;
    [SerializeField] private ScoreUI _scoreCanvas = default;
    [SerializeField] private ScoreTrigger _scoreTrigger = default;
    [SerializeField] private ScoreTrigger_P2 _scoreTrigger_P2 = default;

    public void OnUpdate()
    { 
        CheckCanScore();
    }

    public void CheckCanScore()
    {
        if(_scoreTrigger.GetIsPlayer1Score())
        {
            _score.AddPlayer2Score();
            _scoreCanvas.UpdatePlayer2Text(_score.GetPlayer2Score().ToString());
            _scoreTrigger.SetIsPlayer1Score(false);

        }
        else if(_scoreTrigger_P2.GetIsPlayer2Score())
        {
            _score.AddPlayer1Score();
            _scoreCanvas.UpdatePlayer1Text(_score.GetPlayer1Score().ToString());
            _scoreTrigger_P2.SetIsPlayer2Score(false);
        }
    }
}
