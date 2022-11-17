using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UIComponents
{
    public class ImageSelectOptions : MonoBehaviour, ISelectHandler, IDeselectHandler
    {
        [SerializeField] private Image _image;
        [SerializeField] private Color _normalColor = Color.gray;
        [SerializeField] private Color _selectColor = Color.white;

        private void OnValidate()
        {
            if (_image == null) _image = GetComponentInChildren<Image>();
        }

        private void OnEnable()
        {
            OnDeselect(null);
        }

        public void OnSelect(BaseEventData eventData)
        {
            _image.color = _selectColor;
        }

        public void OnDeselect(BaseEventData eventData)
        {
            _image.color = _normalColor;
        }
    }
}
