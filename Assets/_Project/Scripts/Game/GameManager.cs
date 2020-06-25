using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ResetPositions _resetPositions = default;
    [SerializeField] private TimeManager _timeManager = default;
    [SerializeField] private Score _score = default;
    [SerializeField] private GameObject[] _VictoryObjects = default;


    public void Start()
    {
        _resetPositions.TakeInitialPostions();
        Time.timeScale = 1;
    }

    public void Update()
    {
        _resetPositions.ResetToInitialPositions();
        CheckVictory();
    }

    public void CheckVictory()
    {
        if(_timeManager.CheckEndGame())
        {
            if (_score.GetPlayer1Score() > _score.GetPlayer2Score())
            {
                _VictoryObjects[0].SetActive(true);
            }
            else if(_score.GetPlayer1Score() < _score.GetPlayer2Score())
            {
                _VictoryObjects[1].SetActive(true);
            }
            else
            {
                _VictoryObjects[2].SetActive(true);
            }

            _VictoryObjects[3].SetActive(true);
            _VictoryObjects[4].SetActive(true);
            Time.timeScale = 0;
        }
    }
}
