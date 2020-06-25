using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostManager : MonoBehaviour
{
    [SerializeField] private BoostSpawner _boostSpawner = default;
    [SerializeField] private Ball _ball = default;
    [SerializeField] private BallUI _ballUI = default;
    [SerializeField] private PlayerBase[] _players = default;
    [SerializeField] private BoostTime _boostTime = default;
    private GameObject _spawnedBoost;
    private BoostBallBase _boostBall;
    private BoostPlayerBase _boostPlayer;
    
    void Start()
    {

    }

    private void Update()
    {
        CheckCanSpawn();
        CheckCollisionWithBall();
        CheckInSceneTimeLimit();
        CheckOnDestroyTimeLimit();
        CheckIfEffectStarted();
        ResetPlayerAndBallDefault();
        Debug.Log(_ball.GetIsPlayer1());
    }

    public void ResetPlayerAndBallDefault()
    {
        if (_boostTime.GetEffectTime() > _boostTime.GetEffectMaxTime())
        {
            _ball.ResetDefault();
            _ballUI.SetNormalBallSprite();
            _players[0].ResetDefault();
            _players[1].ResetDefault();
            _boostSpawner.SetCanSpawn(true);
            _boostTime.ResetEffectCountdown();
            _boostTime.ResetInSceneTime();
            _boostTime.SetCanStartEffectTime(false);
        }
    }

    public void CheckIfEffectStarted()
    {
        if (_boostTime.GetCanStartEffectTime())
        {
            _boostTime.EffectCountdown();
        }
    }

    public void CheckOnDestroyTimeLimit()
    {
        if (_boostTime.GetOnDestroyTime() > _boostTime.GetOnDestroyMaxTime())
        {
            _boostSpawner.SetCanSpawn(true);
            _boostTime.ResetInSceneTime();
            _boostTime.ResetOnDestroyCountdown();
        }
    }

    public void CheckInSceneTimeLimit()
    {
        if (_boostTime.GetInSceneTime() > _boostTime.GetInSceneMaxTime())
        {
            Destroy(_spawnedBoost);
            _boostTime.OnDestroyCountdown();
        }
    }

    public void CheckCollisionWithBall()
    {
        if (_boostPlayer != null)
        {
            if (_boostPlayer.GetCollided())
            {
                Destroy(_spawnedBoost);
                _boostTime.SetCanStartEffectTime(true);
            }
            else
            {
                _boostTime.InSceneCountdown();
            }
        }

        if (_boostBall != null)
        {
            if (_boostBall.GetCollided())
            {
                Destroy(_spawnedBoost);
                _boostTime.SetCanStartEffectTime(true);
            }
            else
            {
                _boostTime.InSceneCountdown();
            }
        }
    }

    public void CheckCanSpawn()
    {
        if (_boostSpawner.GetCanSpawn())
        {
            _spawnedBoost = _boostSpawner.SpawnBoost();
            if (_spawnedBoost.GetComponent<BoostBallBase>() != null)
            {
                _boostBall = _spawnedBoost.GetComponent<BoostBallBase>();
                _boostBall.InitializeBall(_ball, _ballUI);
            }
            else if (_spawnedBoost.GetComponent<BoostPlayerBase>() != null)
            {
                _boostPlayer = _spawnedBoost.GetComponent<BoostPlayerBase>();
                if (_ball.GetIsPlayer1())
                {
                    _boostPlayer.InitializePlayer(_players[0]);
                }
                else
                {
                    _boostPlayer.InitializePlayer(_players[1]);
                }
            }

            _boostSpawner.SetCanSpawn(false);
        }
    }
}
