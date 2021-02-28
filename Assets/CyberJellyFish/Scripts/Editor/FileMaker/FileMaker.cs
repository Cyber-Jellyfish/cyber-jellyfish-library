#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEngine;


namespace CyberJellyFish.Editors
{
    public static class FileMaker
    {
        #region VARIABLES

        #endregion

        #region METHODS

        [MenuItem("Assets/Create/File/Text File", priority = 80)]
        public static void CreateTextFile()
        {
            string path = GetSelectedPath.GetSelectedPathOrFallback();
            path = Path.Combine(path, "text-file.txt");
            ProjectWindowUtil.CreateAssetWithContent(path, "");
            AssetDatabase.Refresh();
        }

        [MenuItem("Assets/Create/File/Json File", priority = 80)]
        public static void CreateJsonFile()
        {
            string path = GetSelectedPath.GetSelectedPathOrFallback();
            path = Path.Combine(path, "new-json.json");
            ProjectWindowUtil.CreateAssetWithContent(path, "{\n}");
            AssetDatabase.Refresh();
        }

        #endregion
    }
}
#endif