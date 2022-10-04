using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] 
    private AudioSource _goalScream;
    [SerializeField] 
    private AudioSource _victory;
    [SerializeField] 
    private AudioSource _whistleStart;
    [SerializeField] 
    private AudioSource _whistleEnd; 

    [Header("Kick")]
    [SerializeField]
    private AudioRandomizer[] _randomizer;
    [SerializeField]
    private AudioSource _kick; 

    public void PlayGoalScream()
    {
        _goalScream.volume = 1f;
        _goalScream.Play();
        StartCoroutine(FadeAudioSource.Fade(_goalScream, 3.5f, 0f));
    }

    public void PlayWhistleStart()
    {
        _whistleStart.Play();
    }

    public void PlayWhistleEnd()
    {
        _whistleEnd.Play();
    }

    public void PlayVictory()
    {
        _victory.Play();
        StartCoroutine(FadeAudioSource.Fade(_victory, 3.5f, 0f));
    }

    public void PlayHighKick()
    {
        _randomizer[0].Play(_kick);
    }

    public void PlayLowKick()
    {
        _randomizer[1].Play(_kick);
    }
}
