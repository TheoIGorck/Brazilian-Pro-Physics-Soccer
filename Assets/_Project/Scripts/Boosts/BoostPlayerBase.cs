using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BoostPlayerBase : MonoBehaviour 
{
    private bool _collided = false;

    public abstract void InitializePlayer(PlayerBase player);

    public bool GetCollided()
    {
        return _collided;
    }

    public void SetCollided(bool collided)
    {
        _collided = collided;
    }
}
