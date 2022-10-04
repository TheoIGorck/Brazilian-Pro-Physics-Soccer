using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField]
    private Score _score;
    [SerializeField]
    private ScoreUI _scoreUI;

    private void Awake()
    {
        IsActive = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12 && IsActive)
        {
            _score.Add();
            _scoreUI.UpdateText(_score.ScoreAmount.ToString());
            IsActive = false;
        }
    }

    public bool IsActive { get; set; }
}
