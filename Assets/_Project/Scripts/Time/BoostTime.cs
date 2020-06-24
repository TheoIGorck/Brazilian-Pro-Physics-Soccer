using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostTime : MonoBehaviour
{
    private float _inSceneMaxTime = 4f;
    private float _inSceneCurrentTime = 0;
    private float _onDestroyMaxTime = 3f;
    private float _onDestroyCurrentTime = 0;
    private float _effectMaxTime = 5f;
    private float _effectCurrentTime = 0;
    private bool _canStartEffectTime = false;

    public void EffectCountdown()
    {
        if(_effectCurrentTime < _effectMaxTime)
        {
            _effectCurrentTime += 1 * Time.deltaTime;
        }
    }

    public void ResetEffectCountdown()
    {
        _effectCurrentTime = 0;
    }

    public float GetEffectTime()
    {
        return _effectCurrentTime;
    }

    public float GetEffectMaxTime()
    {
        return _effectMaxTime;
    }

    public void OnDestroyCountdown()
    {
        if(_onDestroyCurrentTime < _onDestroyMaxTime)
        {
            _onDestroyCurrentTime += 1 * Time.deltaTime;
        }
    }
    
    public void ResetOnDestroyCountdown()
    {
        _onDestroyCurrentTime = 0;
    }

    public float GetOnDestroyTime()
    {
        return _onDestroyCurrentTime;
    }

    public float GetOnDestroyMaxTime()
    {
        return _onDestroyMaxTime;
    }

    public void InSceneCountdown()
    {
        if(_inSceneCurrentTime < _inSceneMaxTime)
        {
            _inSceneCurrentTime += 1 * Time.deltaTime;
        }
    }

    public void ResetInSceneTime()
    {
        _inSceneCurrentTime = 0;
    }

    public float GetInSceneTime()
    {
        return _inSceneCurrentTime;
    }

    public float GetInSceneMaxTime()
    {
        return _inSceneMaxTime;
    }

    public bool GetCanStartEffectTime()
    {
        return _canStartEffectTime;
    }

    public void SetCanStartEffectTime(bool canStart)
    {
        _canStartEffectTime = canStart;
    }
}
