using UnityEngine;

public class InputManager : MonoBehaviour
{
    public delegate void MoveAxisUpdatedHandler(int id, float axis);
    public delegate void JumpButtonUpdateHandler(bool Button, int id, float axis);
    public delegate void KickButtonUpdateHandler(bool Button, int id);

    public event MoveAxisUpdatedHandler OnMoveHorizontalAxisUpdated;
    public event JumpButtonUpdateHandler OnJumpButtonUpdate;
    public event KickButtonUpdateHandler OnKickButtonUpdate;

    public void OnUpdate()
    {
        OnMoveHorizontalAxisUpdated.Invoke(0, Input.GetAxis("Horizontal"));
        OnMoveHorizontalAxisUpdated.Invoke(1, Input.GetAxis("Horizontal_P2"));

        OnJumpButtonUpdate.Invoke(Input.GetButtonDown("Jump"), 0, 1f);
        OnJumpButtonUpdate.Invoke(Input.GetButtonDown("Jump_P2"), 1, 1f);

        OnKickButtonUpdate.Invoke(Input.GetButton("Kick"), 0);
        OnKickButtonUpdate.Invoke(Input.GetButton("Kick_P2"), 1);
    }
}
