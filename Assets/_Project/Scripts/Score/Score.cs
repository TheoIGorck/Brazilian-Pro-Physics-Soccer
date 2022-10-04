using UnityEngine;

public class Score : MonoBehaviour
{
    public void Add()
    {
        ScoreAmount++;
    }

    public int ScoreAmount { get; private set; }
}
