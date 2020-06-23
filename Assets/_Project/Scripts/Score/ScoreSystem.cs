using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private ScoreManager _scoreManager = default;

    private void Update()
    {
        _scoreManager.OnUpdate();
    }
}
