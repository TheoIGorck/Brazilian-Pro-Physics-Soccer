using UnityEngine;

public abstract class PlayerBoostBase : MonoBehaviour, IBoost 
{
    protected PlayerBase Player;

    public abstract void Apply();

    public void ResetBoost()
    {
        Player?.Reset();
    }

    public void Initialize(Ball ball)
    {
        Player = ball.LastPlayerToTouch;
    }

    public bool HasCollided { get; set; }
}
