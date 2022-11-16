using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UIComponents
{
    public class SceneHandler : MonoBehaviour
    {
        public void LoadScene(string sceneName)
        {
            Debug.Log($"Loading Scene: {sceneName}");
            SceneManager.LoadScene(sceneName);
        }

        public void Quit()
        {
            Debug.Log("Quitting...");
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.ExitPlaymode();
#endif
        }
    }
}