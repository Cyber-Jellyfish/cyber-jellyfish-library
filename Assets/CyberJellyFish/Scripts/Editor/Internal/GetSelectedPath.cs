#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CyberJellyFish.Editors
{
    public class GetSelectedPath : MonoBehaviour
    {
        #region METHODS

        public static string GetSelectedPathOrFallback()
        {
            string path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (string.IsNullOrEmpty(path) || !File.Exists(path)) return "Assets";
            return Path.GetDirectoryName(path);
        }

        #endregion
    }
}
#endif