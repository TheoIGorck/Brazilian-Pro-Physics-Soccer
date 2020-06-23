using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private Text _player1Score = default;
    [SerializeField] private Text _player2Score = default;

    public void UpdatePlayer1Text(string score)
    {
        _player1Score.text = score;
    }

    public void UpdatePlayer2Text(string score)
    {
        _player2Score.text = score;
    }
}
