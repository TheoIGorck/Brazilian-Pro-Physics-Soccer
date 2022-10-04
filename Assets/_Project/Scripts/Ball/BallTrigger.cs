using UnityEngine;

public class BallTrigger : MonoBehaviour
{
    [SerializeField] 
    private PlayerBase[] _players = default;
    [SerializeField]
    private Ball _ball;
    [SerializeField]
    private AudioManager _audioManager;

    private int _horizontalSpeedThreshold = 12;
    private int _vericalSpeedThreshold = -8;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        string colliderName = collider.transform.root.name;

        if(colliderName == "Player_Isaquias")
        {
            _ball.LastPlayerToTouch = _players[0];
        }
        else if(colliderName == "Player_Elstor")
        {
            _ball.LastPlayerToTouch = _players[1];
        }

        if (collider.gameObject.layer == 9)
        {
            if (_ball.LastPlayerToTouch.HasKicked)
            {
                _ball.RigidBody.AddForce(_ball.LastPlayerToTouch.KickForce);
                _audioManager.PlayHighKick();
            }
        }

        Vector3 ballVelocity = _ball.RigidBody.velocity;

        if(Mathf.Abs(ballVelocity.x) > _horizontalSpeedThreshold || _ball.RigidBody.velocity.y < _vericalSpeedThreshold)
        {
            _audioManager.PlayLowKick();
        }
    }
}
