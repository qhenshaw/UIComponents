using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UIComponents
{
    public class SetSliderValue : MonoBehaviour
    {
        [SerializeField] private FloatSetting _setting;

        private void OnEnable()
        {
            GetComponent<Slider>().SetValueWithoutNotify(_setting.GetSliderValue());
        }
    }
}