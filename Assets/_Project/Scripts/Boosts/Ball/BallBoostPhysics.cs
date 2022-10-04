using UnityEngine;

public class BallBoostPhysics : BallBoostBase
{
    [SerializeField] 
    private PhysicsMaterial2D _physicsMaterial = default;
    [SerializeField]
    private Sprite _ballSprite;

    public override void Apply()
    {
        Ball.BallView.SetBallSprite(_ballSprite);
        Ball.CircleCollider.sharedMaterial = _physicsMaterial;
    }
}
