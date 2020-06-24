using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostBigBall : BoostBallBase
{
    [SerializeField] private Ball _ball = default;
    [SerializeField] private BallUI _ballUI = default;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 12)
        {
            _ball.GrowUp();
            SetCollided(true);
        }
    }
    
    public override void InitializeBall(Ball ball, BallUI ballUI)
    {
        _ball = ball;
        _ballUI = ballUI;
    }
}
