using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _boosts = default;
    [SerializeField] private Transform[] _boostsPositions = default;
    private GameObject _spawnedObject;
    private bool _canSpawnBoost = true;
    private int _positionIndex;
    private int _minPositionIndex = 0;
    private int _maxPositionIndex = 5;
    private int _boostIndex;
    private int _minBoostIndex = 0;
    private int _maxBoostIndex = 10;
    
    public GameObject SpawnBoost()
    {
        _spawnedObject = Instantiate(_boosts[RandomizeBoosts()], _boostsPositions[RandomizePosition()].position, Quaternion.identity);
        return _spawnedObject;
    }

    public int RandomizeBoosts()
    {
        _boostIndex = Random.Range(_minBoostIndex, _maxBoostIndex);
        return _boostIndex;
    }

    public int RandomizePosition()
    {
        _positionIndex = Random.Range(_minPositionIndex, _maxPositionIndex);
        return _positionIndex;
    }

    public void SetCanSpawn(bool canSpawn)
    {
        _canSpawnBoost = canSpawn;
    }

    public bool GetCanSpawn()
    {
        return _canSpawnBoost;
    }
}
