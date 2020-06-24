using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostShrink : BoostPlayerBase
{
    [SerializeField] private PlayerBase _player = default;
    private Vector3 _playerScale = new Vector3(0.3f, 0.3f, 1);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            _player.SetScale(_playerScale);
            SetCollided(true);
        }
    }

    public override void InitializePlayer(PlayerBase player)
    {
        _player = player;
    }
}
