using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public delegate void MoveAxisUpdatedHandler(int id, float axis);
    public delegate void JumpButtonUpdateHandler(bool Button, int id, float axis);
    public delegate void KickButtonUpdateHandler(bool Button, int id, bool facing_Right);
    public delegate void SpecialPowerButtonUpdateHandler(bool Button, int id);

    public event MoveAxisUpdatedHandler OnMoveHorizontalAxisUpdated;
    public event JumpButtonUpdateHandler OnJumpButtonUpdate;
    public event KickButtonUpdateHandler OnKickButtonUpdate;
    public event SpecialPowerButtonUpdateHandler OnSpecialPowerButtonUpdate;

    public void OnFixedUpdate()
    {
        OnMoveHorizontalAxisUpdated.Invoke(0, Input.GetAxis("Horizontal"));
        OnMoveHorizontalAxisUpdated.Invoke(1, Input.GetAxis("Horizontal_P2"));

        OnJumpButtonUpdate.Invoke(Input.GetButtonDown("Jump"), 0, 1f);
        OnJumpButtonUpdate.Invoke(Input.GetButtonDown("Jump_P2"), 1, 1f);

        OnKickButtonUpdate.Invoke(Input.GetButton("Kick"), 0, false);
        OnKickButtonUpdate.Invoke(Input.GetButton("Kick_P2"), 1, true);

        OnSpecialPowerButtonUpdate.Invoke(Input.GetButtonDown("SpecialPower"), 0);
        OnSpecialPowerButtonUpdate.Invoke(Input.GetButtonDown("SpecialPower_P2"), 1);
    }

}
