using UnityEngine;

public class BallView : MonoBehaviour
{
    [SerializeField] 
    private SpriteRenderer _ballRenderer = default;
    [SerializeField]
    private Sprite _defaultSprite = default;

    public void SetBallSprite(Sprite ballSprite)
    {
        _ballRenderer.sprite = ballSprite;
    }

    public void ResetSprite()
    {
        _ballRenderer.sprite = _defaultSprite;
    }
}
