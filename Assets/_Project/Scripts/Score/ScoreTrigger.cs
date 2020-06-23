using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private bool _isPlayer1Score = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            _isPlayer1Score = true;
        }
    }

    public bool GetIsPlayer1Score()
    {
        return _isPlayer1Score;
    }

    public void SetIsPlayer1Score(bool value)
    {
        _isPlayer1Score = value;

    }
}
