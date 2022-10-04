using UnityEngine;

public class PlayerBoostSize : PlayerBoostBase
{
    [SerializeField]
    private float _scaleMultiplier;

    public override void Apply()
    {
        Player?.ChangeScale(_scaleMultiplier);
    }
}
