﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSlowDown : BoostPlayerBase
{
    [SerializeField] private PlayerBase _player = default;
    private float _playerSpeed = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            _player.SetSpeed(_playerSpeed);
            SetCollided(true);
        }
    }

    public override void InitializePlayer(PlayerBase player)
    {
        _player = player;
    }
}
