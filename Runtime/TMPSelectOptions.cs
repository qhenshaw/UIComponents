using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

namespace UIComponents
{
    public class TMPSelectOptions : MonoBehaviour, ISelectHandler, IDeselectHandler
    {
        [System.Serializable]
        private class TextOptions
        {
            public Color Color = Color.white;
            public FontStyles Style;
        }

        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private TextOptions _normalOptions;
        [SerializeField] private TextOptions _selectOptions;

        private void OnValidate()
        {
            if (_text == null) _text = GetComponentInChildren<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            OnDeselect(null);
        }

        public void OnSelect(BaseEventData eventData)
        {
            _text.color = _selectOptions.Color;
            _text.fontStyle = _selectOptions.Style;
        }

        public void OnDeselect(BaseEventData eventData)
        {
            _text.color = _normalOptions.Color;
            _text.fontStyle = _normalOptions.Style;
        }
    }
}
