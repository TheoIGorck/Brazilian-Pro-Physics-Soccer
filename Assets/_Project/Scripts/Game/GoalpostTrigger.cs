using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalpostTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _ball = default;
    [SerializeField] private bool _isLeftGoalpost = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            if (_isLeftGoalpost)
            {
                _ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.05f, 0));
            }
            else
            {
                _ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.05f, 0));
            }
        }
    }
}
