using UnityEngine;

public class MultiplayerSystem : MonoBehaviour
{
    [SerializeField] 
    private InputManager _inputManager = default;
    [SerializeField] 
    private PlayerManager _playerManager = default;

    private void Awake()
    {
        _inputManager.OnMoveHorizontalAxisUpdated += _playerManager.Move;
        _inputManager.OnJumpButtonUpdate += _playerManager.Jump;
        _inputManager.OnKickButtonUpdate += _playerManager.Kick;
    }

    private void Update()
    {
        _inputManager.OnUpdate();
    }
}
