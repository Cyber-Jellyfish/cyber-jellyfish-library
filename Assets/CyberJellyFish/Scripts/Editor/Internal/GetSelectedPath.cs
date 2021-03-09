#if UNITY_EDITOR
using System.IO;
using UnityEditor;

namespace CyberJellyFish.Editors
{
    public static class GetSelectedPath
    {
        #region METHODS

        public static string GetSelectedFolderPathOrFallback()
        {
            string path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (File.Exists(path)) path = Path.GetDirectoryName(path);
            if (string.IsNullOrEmpty(path) || !Directory.Exists(path)) return "Assets";
            return path;
        }

        public static string GetSelectedFilePathOrFallback()
        {
            string path = AssetDatabase.GetAssetPath(Selection.activeObject);
            return File.Exists(path) ? path : string.Empty;
        }

        #endregion
    }
}
#endif