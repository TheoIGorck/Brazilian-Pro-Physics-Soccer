using UnityEngine;

public class PauseView : MonoBehaviour
{
    [SerializeField]
    private TimeManager _timeManager;
    [SerializeField]
    private Canvas _pauseCanvas;
    [SerializeField]
    private RectTransform _pausePanel;
    [SerializeField]
    private float _moveAmount;

    public void Show()
    {
        LeanTween.moveY(_pausePanel, _moveAmount, 1f).setEaseInOutBack().setOnComplete(OnShowComplete);
    }

    public void Hide()
    {
        LeanTween.moveY(_pausePanel, 0, 1f).setEaseInOutBack().setOnComplete(OnHideComplete);
    }

    private void OnShowComplete()
    {
        _timeManager.PauseGame();
    }

    private void OnHideComplete()
    {
        _pauseCanvas.enabled = false;
        _timeManager.ResumeTime();
    }
}
