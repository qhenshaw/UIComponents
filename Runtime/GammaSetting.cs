using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UIComponents
{
    [CreateAssetMenu(menuName = "Settings/Gamma Setting")]
    public class GammaSetting : FloatSetting
    {
        [Header("Gamma")]
        [SerializeField] private VolumeProfile _volumeProfile;

        public override void SetValue(float newValue)
        {
            base.SetValue(newValue);

            if (_volumeProfile.TryGet(out LiftGammaGain liftGammaGain))
            {
                liftGammaGain.gamma.value = Vector4.one * newValue;
            }
            else
            {
                Debug.LogWarning($"Volume Profile: {_volumeProfile.name} is missing Lift Gamma Gain component.", _volumeProfile);
            }
        }
    }
}