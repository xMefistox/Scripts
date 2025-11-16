using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Zenject;

namespace Common
{
    public class AudioButton : Button
    {
        private AudioManager _audioManager;
        private AudioClip _audioClip;

        [Inject]
        public void Construct(AudioManager audioManager)
        {
            _audioManager = audioManager;
        }

        public override void OnPointerClick(PointerEventData eventData)
        {
            base.OnPointerClick(eventData);
            _audioManager.PlayAudio(_audioClip);
        }
    }
}
