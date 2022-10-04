using UnityEngine;

public class AudioRandomizer : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] _clips;

    [SerializeField]
    private FloatRange _volume;

    [SerializeField]
    private FloatRange _pitch;

    public void Play(AudioSource source)
    {
        if(_clips.Length == 0)
        {
            return;
        }

        AudioClip clip = _clips[Random.Range(0, _clips.Length)];
        float volume = Random.Range(_volume.MinValue, _volume.MaxValue);
        source.pitch = Random.Range(_pitch.MinValue, _pitch.MaxValue);
        source.PlayOneShot(clip, volume);
    }
}
