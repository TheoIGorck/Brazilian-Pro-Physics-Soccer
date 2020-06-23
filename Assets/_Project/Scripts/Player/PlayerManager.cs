using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private PlayerBase[] _players = default;
    
    public void Move(int id, float axis)
    {
        _players[id].Move(axis);
    }

    public void Jump(bool Button, int id, float axis)
    {
        if(_players[id].isGrounded() && Button)
        {
            _players[id].Jump(Button, axis);
        }
    }

    public void Kick(bool Button, int id, bool facing_Right)
    {
        if (Button)
        {
            _players[id].Kick(Button, facing_Right);
        }
        else
        {
            _players[id].ReturnFootToInitialPosition(facing_Right);
        }
    }

    public void SpecialPower(bool Button, int id)
    {
        if (Button)
        {
            _players[id].SpecialPower(Button);
        }
    }
}
