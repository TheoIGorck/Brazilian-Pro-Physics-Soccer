using UnityEngine;

public abstract class PlayerBase : MonoBehaviour
{
    protected Quaternion CurrentRotation;
    protected Vector3 CurrentEulerAngles;
    protected Quaternion MaxFootRotation = Quaternion.Euler(new Vector3(0, 0, 20));
    protected Quaternion MinFootRotation = Quaternion.Euler(new Vector3 (0, 0, -20));

    [SerializeField] 
    private GameObject _boost = default;
    [SerializeField] 
    private Rigidbody2D _playerBody = default;

    [Header("Kick")]
    [SerializeField] 
    protected GameObject PlayerFoot = default;
    [SerializeField] 
    protected float FootRotateSpeed = default;
    [SerializeField] 
    private Vector2 _kickForce = default;

    [Header("Attributes")]
    [SerializeField] 
    private float _initialSpeed = default;
    [SerializeField] 
    private float _initialImpulse = default;
    
    [Header("Ground Check")]
    [SerializeField] 
    private LayerMask _layerMask = default;
    [SerializeField] 
    private PolygonCollider2D _playerCollider = default;

    private RaycastHit2D _raycastHit;
    private Vector3 _initialScale;
    private float _extraRaycastHeight = 0.3f;
    private float _speed;
    private float _impulse;
    
    public virtual void Kick()
    {
        HasKicked = true;
    }

    public virtual void ReturnFootToInitialPosition()
    {
        HasKicked = false;
    }

    public virtual void Move(float axis)
    {
        _playerBody.velocity = new Vector2(axis * _speed, _playerBody.velocity.y);
    }

    public virtual void Jump(float axis)
    {
        _playerBody.velocity = new Vector2(_playerBody.velocity.x, axis * _impulse);
    }

    public bool IsGrounded()
    {
        _raycastHit = Physics2D.Raycast(_playerCollider.bounds.center, Vector2.down, _playerCollider.bounds.extents.y + _extraRaycastHeight, _layerMask);

        return _raycastHit.collider != null;
    }

    public void Reset()
    {
        transform.localScale = _initialScale;
        _speed = _initialSpeed;
        _impulse = _initialImpulse;
        _boost.gameObject.SetActive(false);
    }

    public void ChangeScale(float scaleMultiplier)
    {
        transform.localScale *= scaleMultiplier;
    }

    public void SetBoostSprite(GameObject boost)
    {
        _boost = boost;
        boost.transform.position = transform.position;
        boost.transform.SetParent(transform);
        boost.gameObject.SetActive(true);
    }

    private void Awake()
    {
        _initialScale = transform.localScale;
        _speed = _initialSpeed;
        _impulse = _initialImpulse;
    }

    public Vector2 KickForce { get => _kickForce; }
    public bool HasKicked { get; private set; }
    public float InitialImpulse { get => _initialImpulse; }
    public float InitialSpeed { get => _initialSpeed; }
    public float Impulse { get => _impulse; set => _impulse = value; }
    public float Speed { get => _speed; set => _speed = value; }
}
