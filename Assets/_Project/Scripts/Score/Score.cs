using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int _player1Score = 0;
    private int _player2Score = 0;

    public void AddPlayer1Score()
    {
        _player1Score += 1;
    }

    public void AddPlayer2Score()
    {
        _player2Score += 1;
    }

    public int GetPlayer1Score()
    {
        return _player1Score;
    }

    public int GetPlayer2Score()
    {
        return _player2Score;
    }
}
