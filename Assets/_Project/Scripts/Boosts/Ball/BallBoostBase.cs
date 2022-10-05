using UnityEngine;

public abstract class BallBoostBase : MonoBehaviour, IBoost
{
    protected Ball Ball;

    public abstract void Apply();

    public void ResetBoost()
    {
        Ball?.Reset();
    }

    public void Initialize(Ball ball)
    {
        Ball = ball;
    }

    public bool HasCollided { get; set; }
}
