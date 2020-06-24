using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector3 _bigBallSize = default;
    [SerializeField] private Vector3 _smallBallSize = default;
    [SerializeField] private Vector3 _normalBallSize = default;
    [SerializeField] private PhysicsMaterial2D[] _physicsMaterials = default;
    [SerializeField] private Rigidbody2D _ballRigidbody2D = default;
    [SerializeField] private CircleCollider2D _circleCollider2D = default;
    private bool _isPlayer1 = true;

    public void GrowUp()
    {
        transform.localScale = _bigBallSize;
    }
    
    public void Shrink()
    {
         transform.localScale = _smallBallSize;
    }

    public void DeadBall()
    {
        _ballRigidbody2D.sharedMaterial = _physicsMaterials[1];
        _circleCollider2D.sharedMaterial = _physicsMaterials[1];
    }

    public void BouncyBall()
    {
        _ballRigidbody2D.sharedMaterial = _physicsMaterials[2];
        _circleCollider2D.sharedMaterial = _physicsMaterials[2];
    }

    public void ResetDefault()
    {
        _ballRigidbody2D.sharedMaterial = _physicsMaterials[0];
        _circleCollider2D.sharedMaterial = _physicsMaterials[0];
        transform.localScale = _normalBallSize;
    }

    public void SetIsPlayer1(bool isPlayer1)
    {
        _isPlayer1 = isPlayer1;
    }

    public bool GetIsPlayer1()
    {
        return _isPlayer1;
    }
}
