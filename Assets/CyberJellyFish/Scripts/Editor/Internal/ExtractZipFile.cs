#if UNITY_EDITOR
using System.IO;
using System.IO.Compression;
using UnityEditor;
using Aspose.Zip.Rar;

namespace CyberJellyFish.Editors
{
    public static class ExtractZipFile
    {
        #region METHODS

        [MenuItem("Assets/Create/Archive/Zip/Extract to Folder", false, 90)]
        public static void ExtractZipToFolder()
        {
            CleanFilePaths(out string inPath, out string outPath);
            ZipFile.ExtractToDirectory(inPath, outPath);
            AssetDatabase.Refresh();
        }

        [MenuItem("Assets/Create/Archive/Rar/Extract to Folder", false, 90)]
        public static void ExtractRarToFolder()
        {
            CleanFilePaths(out string inPath, out string outPath);
            using (RarArchive archive = new RarArchive(inPath))
            {
                archive.ExtractToDirectory(Path.GetDirectoryName(inPath));
            }

            AssetDatabase.Refresh();
        }

        private static void CleanFilePaths(out string inPath, out string outPath)
        {
            outPath = string.Empty;
            inPath = GetSelectedPath.GetSelectedFilePathOrFallback();
            if (string.IsNullOrEmpty(inPath)) return;

            outPath =
                $"{Path.GetDirectoryName(inPath)}{Path.DirectorySeparatorChar}{Path.GetFileNameWithoutExtension(inPath)}";
            if (!Directory.Exists(outPath))
            {
                Directory.CreateDirectory(outPath);
            }
        }

        #endregion
    }
}
#endif