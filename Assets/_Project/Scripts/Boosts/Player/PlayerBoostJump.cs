using UnityEngine;

public class PlayerBoostJump : PlayerBoostBase
{
    [SerializeField] 
    private GameObject _boostObject = default;
    [SerializeField]
    private float _impulseModifier = 9;

    public override void Apply()
    {
        if(Player)
        {
            Player.Impulse = Player.InitialImpulse + _impulseModifier;
            Player.SetBoostSprite(_boostObject);
        }
    }
}
