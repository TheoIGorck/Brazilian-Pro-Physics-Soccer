using UnityEngine;

public class BoostSpawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] _boosts = default;
    [SerializeField] 
    private Transform[] _positions = default;
    
    public GameObject Spawn()
    {
        GameObject spawnedObject = Instantiate(_boosts[GetRandomBoostIndex()], _positions[GetRandomPositionIndex()].position, Quaternion.identity);

        return spawnedObject;
    }

    private void Awake()
    {
        CanSpawn = true;
    }

    private int GetRandomBoostIndex()
    {
        return Random.Range(0, _boosts.Length - 1);
    }

    private int GetRandomPositionIndex()
    {
        return Random.Range(0, _positions.Length - 1);
    }

    public bool CanSpawn { get; set; }
}
