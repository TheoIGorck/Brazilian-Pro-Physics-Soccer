using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerSystem : MonoBehaviour
{
    [SerializeField] private InputManager _inputManager = default;
    [SerializeField] private PlayerManager _playerManager = default;

    private void Awake()
    {
        _inputManager.OnMoveHorizontalAxisUpdated += _playerManager.Move;
        _inputManager.OnJumpButtonUpdate += _playerManager.Jump;
        _inputManager.OnKickButtonUpdate += _playerManager.Kick;
        _inputManager.OnSpecialPowerButtonUpdate += _playerManager.SpecialPower;
    }

    private void Start()
    {
       
    }

    private void FixedUpdate()
    {
        _inputManager.OnFixedUpdate();
    }

}
