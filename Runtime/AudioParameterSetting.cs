using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Debug = UnityEngine.Debug;

#if FMOD
using FMOD;
using FMODUnity;
#endif

namespace UIComponents
{
    [CreateAssetMenu(menuName = "Settings/Audio Parameter Setting (FMOD + Unity Mixer)")]
    public class AudioParameterSetting : FloatSetting
    {
        [Header("Mixer")]
#if FMOD
        [SerializeField, ParamRef] private string _fmodParameter = "";      //FMOD parameter selector in inspector
#else
        [SerializeField] private AudioMixer _audioMixer;
        [SerializeField] private string _parameterName = "Parameter Name";
#endif

        public override void SetValue(float newValue)
        {
            base.SetValue(newValue);

#if FMOD
            if (!string.IsNullOrEmpty(_fmodParameter))
            {
                RESULT result = RuntimeManager.StudioSystem.setParameterByName(_fmodParameter, newValue);
                if (result != RESULT.OK)
                {
                    Debug.LogError(string.Format("[FMOD] StudioGlobalParameterTrigger failed to set parameter {0} : result = {1}", _fmodParameter, result));
                }
            }
#else
            _audioMixer.SetFloat(_parameterName, newValue);
#endif
        }
    }
}