using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody2D _ballRigidbody2D = default;
    [SerializeField] 
    private CircleCollider2D _circleCollider2D = default;
    [SerializeField] 
    private PhysicsMaterial2D _physicsMaterial = default;
    [SerializeField]
    public BallView _ballView;
    [SerializeField]
    private Vector3 _size = default;

    public void ResetVelocity(Vector3 direction)
    {
        _ballRigidbody2D.velocity = direction;
    }

    public void Reset()
    {
        transform.localScale = _size;
        _circleCollider2D.sharedMaterial = _physicsMaterial;
        _ballView.ResetSprite();
    }
    
    public Rigidbody2D RigidBody { get => _ballRigidbody2D; }
    public CircleCollider2D CircleCollider { get => _circleCollider2D; }
    public BallView BallView { get => _ballView; }
    public PlayerBase LastPlayerToTouch { get; set; }
}
