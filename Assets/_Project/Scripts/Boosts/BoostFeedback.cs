using UnityEngine;

public class BoostFeedback : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource; 
    [SerializeField]
    private ParticleSystem _particleSystem;

    private ParticleSystem _currentParticleSystem;
    
    public void PlaySound()
    {
        _audioSource.Play();
    }

    public void PlayParticleSystem(Vector3 position)
    {
        if(_currentParticleSystem == null)
        {
            _currentParticleSystem = Instantiate(_particleSystem, position, Quaternion.identity);
        }

        _currentParticleSystem.transform.position = position;
        _currentParticleSystem.Play();
    }

    public void Play(Vector3 position)
    {
        PlaySound();
        PlayParticleSystem(position);
    }
}
