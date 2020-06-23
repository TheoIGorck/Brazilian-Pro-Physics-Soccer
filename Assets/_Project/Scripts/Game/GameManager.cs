using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ResetPositions _resetPositions = default;

    public void Start()
    {
        _resetPositions.TakeInitialPostions();
    }

    public void Update()
    {
        _resetPositions.ResetToInitialPositions();
    }
}
