using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIComponents
{
    public class SetCursorLockMode : MonoBehaviour
    {
        public void SetModeNone()
        {
            Cursor.lockState = CursorLockMode.None;
        }

        public void SetModeConfined()
        {
            Cursor.lockState = CursorLockMode.Confined;
        }

        public void SetModeLocked()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}