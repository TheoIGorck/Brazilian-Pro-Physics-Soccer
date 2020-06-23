using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger_P2 : MonoBehaviour
{
    private bool _isPlayer2Score = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            _isPlayer2Score = true;
        }
    }

    public bool GetIsPlayer2Score()
    {
        return _isPlayer2Score;
    }

    public void SetIsPlayer2Score(bool value)
    {
        _isPlayer2Score = value;

    }
}
