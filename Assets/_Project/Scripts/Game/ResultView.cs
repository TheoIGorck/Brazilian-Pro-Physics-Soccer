using UnityEngine;

public class ResultView : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] _VictoryObjects = default;
    [SerializeField] 
    private Canvas _resultCanvas = default;

    public void Show(ScoreManager scoreManager)
    {
        if (scoreManager.IsADraw())
        {
            _VictoryObjects[2].SetActive(true);
        }
        else if(scoreManager.IsPlayer1Winner())
        {
            _VictoryObjects[0].SetActive(true);
        }
        else
        {
            _VictoryObjects[1].SetActive(true);
        }

        _resultCanvas.enabled = true;
    }
}
