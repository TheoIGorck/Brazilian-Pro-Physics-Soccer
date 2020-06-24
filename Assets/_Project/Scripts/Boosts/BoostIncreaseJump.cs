using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostIncreaseJump : BoostPlayerBase
{
    [SerializeField] private PlayerBase _player = default;
    private float _playerImpulse = 8;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            _player.SetImpulse(_playerImpulse);
            SetCollided(true);
        }
    }

    public override void InitializePlayer(PlayerBase player)
    {
        _player = player;
    }
}
