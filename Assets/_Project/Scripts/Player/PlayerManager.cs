using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] 
    private PlayerBase[] _players = default;
    
    public void Move(int id, float axis)
    {
        _players[id].Move(axis);
    }

    public void Jump(bool button, int id, float axis)
    {
        if(_players[id].IsGrounded() && button)
        {
            _players[id].Jump(axis);
        }
    }

    public void Kick(bool button, int id)
    {
        if (button)
        {
            _players[id].Kick();
        }
        else
        {
            _players[id].ReturnFootToInitialPosition();
        }
    }
}
