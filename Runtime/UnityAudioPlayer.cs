using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace UIComponents
{
    [CreateAssetMenu(menuName = "Unity Audio Player")]
    public class UnityAudioPlayer : ScriptableObject
    {
        [SerializeField] private AudioMixerGroup _mixerGroup;

        public void PlayOneShot2D(AudioClip audioClip)
        {
            GameObject go = new GameObject($"Audio: {audioClip.name}");
            AudioSource source = go.AddComponent<AudioSource>();
            source.playOnAwake = false;
            source.outputAudioMixerGroup = _mixerGroup;
            source.clip = audioClip;
            source.loop = false;
            source.spatialBlend = 0f;
            source.Play();
            Destroy(go, audioClip.length);
        }
    }
}
