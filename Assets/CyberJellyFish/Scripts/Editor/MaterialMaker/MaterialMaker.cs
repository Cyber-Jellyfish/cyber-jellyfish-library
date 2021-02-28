#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CyberJellyFish.Editors
{
    public static class MaterialMaker
    {
        #region VARIABLES

        private static readonly int    _Color = Shader.PropertyToID("_Color");
        private static          string _directoryPath => Path.Combine(Application.dataPath, "Resources", "Materials");
        private static          string _path = "Assets/Resources/Materials/";

        #endregion

        #region METHODS

        [MenuItem("Assets/Create/Materials/Random Material Colour", false, 280)]
        public static void CompileMaterial()
        {
            CreateFolder();
            Shader shader = Shader.Find("Standard");
            Material material = new Material(shader);
            Color color = Color.black;
            color.ToRandomColor();
            material.SetColor(_Color, color);
            string[] materials = Directory.GetFiles(_path, "*.mat", SearchOption.TopDirectoryOnly);
            AssetDatabase.CreateAsset(material, $"{_path}/material-{materials.Length}.mat");
            AssetDatabase.Refresh();
        }

        private static void CreateFolder()
        {
            if (Directory.Exists(_directoryPath)) return;
            Directory.CreateDirectory(_directoryPath);
        }

        #endregion
    }
}
#endif