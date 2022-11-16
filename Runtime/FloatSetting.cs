using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIComponents
{
    public class FloatSetting : ScriptableObject
    {
        [Header("Setting")]
        [SerializeField] private string _name;
        [SerializeField] private float _default = 5f;
        [SerializeField] private float _current = 5f;
        [SerializeField] private Vector2 _valueMinMax = new Vector2(0f, 1f);
        [SerializeField] private Vector2 _sliderMinMax = new Vector2(0f, 10f);

        public virtual void SetValue(float newValue)
        {
            PlayerPrefs.SetFloat(_name, newValue);
            _current = newValue;
        }

        public void SetValueFromSlider(float newValue)
        {
            float normalizedValue = Mathf.InverseLerp(_sliderMinMax.x, _sliderMinMax.y, newValue);
            float value = Mathf.Lerp(_valueMinMax.x, _valueMinMax.y, normalizedValue);
            SetValue(value);
        }

        public float GetValue()
        {
            return PlayerPrefs.GetFloat(_name, _default);
        }

        public float GetSliderValue()
        {
            float value = GetValue();
            float normalizedValue = Mathf.InverseLerp(_valueMinMax.x, _valueMinMax.y, value);
            float sliderValue = Mathf.Lerp(_sliderMinMax.x, _sliderMinMax.y, normalizedValue);
            return sliderValue;
        }

        public void Load()
        {
            SetValue(GetValue());
        }
    }
}