using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MixerVolumeController : MonoBehaviour
{
    [SerializeField]
    private string _groupName;

    [SerializeField]
    private Slider _slider;

    [SerializeField]
    private AudioMixer _mixer;

    public void SetVolume(float volume)
    {
        _mixer.SetFloat(_groupName, Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat(_groupName, volume);
    }

    private void Start()
    {
        _slider.value = PlayerPrefs.GetFloat(_groupName, 0.75f);
    }
}
