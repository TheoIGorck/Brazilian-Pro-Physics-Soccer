using UnityEngine;

public class PlayerBoostVelocity : PlayerBoostBase
{
    [SerializeField] 
    private GameObject _boostObject = default;
    [SerializeField]
    private float _speedModifier = 3;

    public override void Apply()
    {
        if(Player)
        {
            Player.Speed = Player.InitialSpeed + _speedModifier;
            Player.SetBoostSprite(_boostObject);
        }
    }
}
