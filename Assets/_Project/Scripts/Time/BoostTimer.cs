using UnityEngine;

public class BoostTimer : MonoBehaviour
{
    [SerializeField]
    private float _inSceneMaxTime = 5f;
    [SerializeField]
    private float _effectMaxTime = 5f;
    [SerializeField]
    private float _destroyMaxTime = 4f;

    private float _inSceneCurrentTime;
    private float _destroyCurrentTime;
    private float _effectCurrentTime;
    private bool _canStartEffectTime = false;

    public void ResetEffectCountdown()
    {
        _effectCurrentTime = 0;
        _inSceneCurrentTime = 0;
        _destroyCurrentTime = 0;
        CanStartEffectTime = false;
    }

    public void ResetDestroyCountdown()
    {
        _inSceneCurrentTime = 0;
        _destroyCurrentTime = 0;
    }

    private void Update()
    {
        if(_inSceneCurrentTime < _inSceneMaxTime)
        {
            _inSceneCurrentTime += 1 * Time.deltaTime;
        }
        else
        {
            DestroyCountdown();
        }

        if (_canStartEffectTime)
        {
            EffectCountdown();
        }
    }

    private void EffectCountdown()
    {
        if(_effectCurrentTime < _effectMaxTime)
        {
            _effectCurrentTime += 1 * Time.deltaTime;
        }
    }

    private void DestroyCountdown()
    {
        if(_destroyCurrentTime < _destroyMaxTime)
        {
            _destroyCurrentTime += 1 * Time.deltaTime;
        }
    }

    public float EffectCurrentTime { get => _effectCurrentTime; }
    public float EffectMaxTime { get => _effectMaxTime; }
    public float OnDestroyCurrentTime { get => _destroyCurrentTime; }
    public float OnDestroyMaxTime { get => _destroyMaxTime; }
    public float InSceneCurrentTime { get => _inSceneCurrentTime; }
    public float InSceneMaxTime { get => _inSceneMaxTime; }
    public bool CanStartEffectTime { get => _canStartEffectTime; set => _canStartEffectTime = value; }
}
