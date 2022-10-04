using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] 
    private Text _score = default;
    [SerializeField] 
    private Text _matchScore = default;

    public void UpdateText(string score)
    {
        _score.text = score;
        _matchScore.text = score;
    }
}
