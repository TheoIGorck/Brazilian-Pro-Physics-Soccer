using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BoostBallBase : MonoBehaviour
{
    private bool _collided = false;

    public abstract void InitializeBall(Ball ball, BallUI ballUI);

    public bool GetCollided()
    {
        return _collided;
    }

    public void SetCollided(bool collided)
    {
        _collided = collided;
    }
}
