using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    [SerializeField] private TimeManager _timeManager = default;

    private void Start()
    {
        _timeManager.OnStart();
    }

    void Update()
    {
        _timeManager.OnUpdate();
    }
}
