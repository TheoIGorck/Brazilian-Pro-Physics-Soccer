using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerBody = default;

    [SerializeField] private float _playerSpeed = default;
    [SerializeField] private float _playerImpulse = default;

    [Header("IsGrounded")]
    [SerializeField] private LayerMask _layerMask = default;
    [SerializeField] private PolygonCollider2D _playerCollider = default;
    private float _extraRaycastHeight = 0.3f;
    private RaycastHit2D _raycastHit;

    [Header("Kick")]
    [SerializeField] private float _footRotateSpeed = default;
    [SerializeField] private GameObject _playerFoot = default;
    [SerializeField] private Vector2 _kickForce = default;
    private Quaternion _maxRotation = Quaternion.Euler(new Vector3(0, 0, 20));
    private Quaternion _minRotation = Quaternion.Euler(new Vector3 (0, 0, -20));
    private Quaternion _currentRotation;
    private Vector3 _currentEulerAngles;
    [SerializeField] private bool _isFacingRight = false;
    private bool _hasKicked;
    
    public void Move(float axis)
    {
        _playerBody.velocity = new Vector2(axis * _playerSpeed, _playerBody.velocity.y);
    }

    public void Jump(bool Button, float axis)
    {
        _playerBody.velocity = new Vector2(_playerBody.velocity.x, axis * _playerImpulse);
    }

    public virtual void Kick(bool Button, bool facing_Right)
    {
        if(facing_Right)
        {
            if(_playerFoot.transform.rotation.z < _maxRotation.z)
            {
                _currentEulerAngles += Vector3.forward * Time.deltaTime * _footRotateSpeed;
                _currentRotation.eulerAngles = _currentEulerAngles;
                _playerFoot.transform.rotation = _currentRotation;
            }
        }
        else
        {
            if(_playerFoot.transform.rotation.z > _minRotation.z)
            {
                _currentEulerAngles -= Vector3.forward * Time.deltaTime * _footRotateSpeed;
                _currentRotation.eulerAngles = _currentEulerAngles;
                _playerFoot.transform.rotation = _currentRotation;
            }
        }

        _hasKicked = true;
    }

    public void ReturnFootToInitialPosition(bool facing_Right)
    {
        _isFacingRight = facing_Right;

        if (facing_Right)
        {
            if (_playerFoot.transform.rotation.z > _minRotation.z)
            {
                _currentEulerAngles -= Vector3.forward * Time.deltaTime * _footRotateSpeed;
                _currentRotation.eulerAngles = _currentEulerAngles;
                _playerFoot.transform.rotation = _currentRotation;
            }
        }
        else
        {
            if (_playerFoot.transform.rotation.z < _maxRotation.z)
            {
                _currentEulerAngles += Vector3.forward * Time.deltaTime * _footRotateSpeed;
                _currentRotation.eulerAngles = _currentEulerAngles;
                _playerFoot.transform.rotation = _currentRotation;
            }
        }

        _hasKicked = false;
    }

    public virtual void SpecialPower(bool Button)
    {
       Debug.Log("Special Power");
    }

    public bool isGrounded()
    {
        _raycastHit = Physics2D.Raycast(_playerCollider.bounds.center, Vector2.down, _playerCollider.bounds.extents.y + _extraRaycastHeight, _layerMask);

        Color rayColor;
        if(_raycastHit.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }

        Debug.DrawRay(_playerCollider.bounds.center, Vector2.down * (_playerCollider.bounds.extents.y + _extraRaycastHeight), rayColor);
        //Debug.Log(_raycastHit.collider);

        return _raycastHit.collider != null;
    }

    public bool GetHasKicked()
    {
        return _hasKicked;
    }

    public bool GetIsFacingRight()
    {
        return _isFacingRight;
    }

    public Vector2 GetKickForce()
    {
        return _kickForce;
    }

    public void SetImpulse(float impulse)
    {
        _playerImpulse = impulse;
    }

    public void SetSpeed(float speed)
    {
        _playerSpeed = speed;
    }

    public void SetScale(Vector3 scale)
    {
        transform.localScale = scale;
    }

    public void ResetDefault()
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 1);
        _playerSpeed = 5;
        _playerImpulse = 7;
    }
}
