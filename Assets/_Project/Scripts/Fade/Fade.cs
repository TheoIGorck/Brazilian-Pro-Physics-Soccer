using System;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [SerializeField]
    private RectTransform _objectToFade;
    [SerializeField]
    private float _timeToFade;

    private LTDescr description;

    public void FadeAlpha(float finalAlpha, Action onFadeComplete)
    {
        if(finalAlpha > 0)
        {
            _objectToFade.GetComponent<Image>().raycastTarget = true;
        }
        else
        {
            _objectToFade.GetComponent<Image>().raycastTarget = false;
        }

        description = LeanTween.alpha(_objectToFade, finalAlpha, _timeToFade).setEase(LeanTweenType.linear);

        if(onFadeComplete != null)
        {
            description.setOnComplete(onFadeComplete);
        }
    }

    private void Awake()
    {
        Time.timeScale = 1;
        FadeAlpha(0, null);
    }
}
