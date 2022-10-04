using UnityEngine;

public class GoalpostTrigger : MonoBehaviour
{
    [SerializeField] 
    private Ball _ball = default;
    [SerializeField] 
    private bool _isLeftGoalpost = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            if (_isLeftGoalpost)
            {
                _ball.RigidBody.AddForce(new Vector2(0.05f, 0));
            }
            else
            {
                _ball.RigidBody.AddForce(new Vector2(-0.05f, 0));
            }
        }
    }
}
