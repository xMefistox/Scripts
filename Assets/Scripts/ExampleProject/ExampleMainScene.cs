using Common;
using UnityEngine;
using Zenject;

public class ExampleMainScene : MonoBehaviour
{
    private IAudioManager _audioManager;
    [SerializeField] AudioClip _backgroundAudioClip;

    [Inject]
    public void Construct(IAudioManager audioManager)
    {
        _audioManager = audioManager;
    }

    private void Start()
    {
        _audioManager.PlayBackground(_backgroundAudioClip);
    }
}
