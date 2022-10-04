using UnityEngine;

public class PlayerIsaquias : PlayerBase
{
    public override void Kick()
    {
        if(PlayerFoot.transform.rotation.z > MinFootRotation.z)
        {
            CurrentEulerAngles -= Vector3.forward * Time.deltaTime * FootRotateSpeed;
            CurrentRotation.eulerAngles = CurrentEulerAngles;
            PlayerFoot.transform.rotation = CurrentRotation;
        }

        base.Kick();
    }

    public override void ReturnFootToInitialPosition()
    {
        if (PlayerFoot.transform.rotation.z < MaxFootRotation.z)
        {
            CurrentEulerAngles += Vector3.forward * Time.deltaTime * FootRotateSpeed;
            CurrentRotation.eulerAngles = CurrentEulerAngles;
            PlayerFoot.transform.rotation = CurrentRotation;
        }

        base.ReturnFootToInitialPosition();
    }
}
