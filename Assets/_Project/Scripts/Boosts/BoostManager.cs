using UnityEngine;

public class BoostManager : MonoBehaviour
{
    [SerializeField] 
    private Ball _ball = default;
    [SerializeField] 
    private BoostSpawner _boostSpawner = default;
    [SerializeField] 
    private BoostTimer _boostTimer = default;
    [SerializeField] 
    private BoostFeedback _boostFeedback;

    private GameObject _spawnedBoost;
    private IBoost _boost;
    
    public void Reset()
    {
        if(_spawnedBoost != null)
        {
            Destroy(_spawnedBoost);
        }

        _boost?.ResetBoost();
        _boostSpawner.CanSpawn = true;
        _boostTimer.ResetEffectCountdown();
    }

    private void Update()
    {
        if(_boostSpawner.CanSpawn)
        {
            SpawnBoost();
        }

        if(_boost != null)
        {
            if(_boost.HasCollided)
            {
                _boost.Initialize(_ball);
                _boost.Apply();
                _boostFeedback.Play(_spawnedBoost.transform.position);
                _spawnedBoost.gameObject.SetActive(false);
                _boostTimer.CanStartEffectTime = true;
                _boost.HasCollided = false;
            }
        }

        if(_boostTimer.InSceneCurrentTime > _boostTimer.InSceneMaxTime)
        {
            Destroy(_spawnedBoost);
        }

        if(_boostTimer.OnDestroyCurrentTime > _boostTimer.OnDestroyMaxTime)
        {
            _boostSpawner.CanSpawn = true;
            _boostTimer.ResetDestroyCountdown();
        }

        if(_boostTimer.EffectCurrentTime > _boostTimer.EffectMaxTime)
        {
            Reset();
        }
    }

    private void SpawnBoost()
    {
        _spawnedBoost = _boostSpawner.Spawn();
        _boost = _spawnedBoost.GetComponent<IBoost>();
        _boostSpawner.CanSpawn = false;
    }
}
