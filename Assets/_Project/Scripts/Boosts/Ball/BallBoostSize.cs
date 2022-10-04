using UnityEngine;

public class BallBoostSize : BallBoostBase
{
    [SerializeField]
    private Vector3 _newSize = default;

    public override void Apply()
    {
        Ball.transform.localScale = _newSize;
    }
}
