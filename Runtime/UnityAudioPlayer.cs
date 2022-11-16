using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIComponents
{
    [CreateAssetMenu(menuName = "Unity Audio Player")]
    public class UnityAudioPlayer : ScriptableObject
    {
        public void PlayOneShot2D(AudioClip audioClip)
        {
            GameObject go = new GameObject($"Audio: {audioClip.name}");
            AudioSource source = go.AddComponent<AudioSource>();
            source.playOnAwake = false;
            source.clip = audioClip;
            source.loop = false;
            source.spatialBlend = 0f;
            source.Play();
            Destroy(go, audioClip.length);
        }
    }
}
