using System;
using UnityEngine;

public class MatchScoreScaler : MonoBehaviour
{
    [SerializeField]
    private GameObject _objectToScale;
    [SerializeField]
    private Vector3 _finalScale;
    [SerializeField]
    private float _timeToScale;

    private Vector3 _initialScale;

    public void ScaleScore(Action onScaleComplete)
    {
        LTDescr description = LeanTween.scale(_objectToScale, _finalScale, _timeToScale);

        if(onScaleComplete != null)
        {
            description.setOnComplete(onScaleComplete);
        }
    }

    public void ResetScale()
    {
        transform.localScale = _initialScale;
    }

    private void Awake()
    {
        _initialScale = transform.localScale;
    }
}
