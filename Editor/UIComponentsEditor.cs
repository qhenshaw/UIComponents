using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UIComponents.Editor
{
    public class UIComponentsEditor
    {
        private static bool LoadSafeRegionOverlay(out GameObject overlay)
        {
            string path = "Packages/UIComponents/Prefabs/SafeRegionOverlay.prefab";
            overlay = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            if(overlay == null)
            {
                Debug.LogWarning("Safe Region Overlay is missing!");
                return false;
            }

            return true;
        }

        [MenuItem("GameObject/UI/Safe Region Overlay")]
        private static void InstantiateSafeRegionOverlay()
        {
            if(LoadSafeRegionOverlay(out GameObject overlay))
            {
                Object.Instantiate(overlay);
            }
        }
    }
}