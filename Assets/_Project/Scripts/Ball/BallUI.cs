using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallUI : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _ballRender = default;
    [SerializeField] private Sprite[] _ballSprite = default;

    public void SetDedBallSprite()
    {
        _ballRender.sprite = _ballSprite[1];
    }

    public void SetBouncyBallSprite()
    {
        _ballRender.sprite = _ballSprite[2];
    }

    public void SetNormalBallSprite()
    {
        _ballRender.sprite = _ballSprite[0];
    }
}
