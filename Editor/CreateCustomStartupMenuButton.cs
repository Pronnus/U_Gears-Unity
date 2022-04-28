using UnityEditor;
using static U.Gears.Editor.UE;

namespace U.Gears.Editor
{
    public class CreateCustomStartupMenuButton : EditorWindow
    {

        #region File
        private static string DefaultFolderName => "/Scripts/Control/Startup/";
        private static string DefaultFileName => "NewStartup";
        private static string CustomExtension => "startup";
        static string[] file(string fileName) => new string[]
        {
            "using UnityEngine;",
            "",
            "public static partial class Startup",
            "{",
            "    [RuntimeInitializeOnLoadMethod]",
            "    public static void "+fileName+"()",
            "    {",
            "",
            "        // Code here",
            "        // ...",
            "",
            "    }",
            "}",
        };
        #endregion File



        private static string FormatLog(string text) => "UniversalGears: " + text;


        [MenuItem("Universal/Gears/Create/Control/Startup")]
        public static void ShowWindow()
        {

            // Create files
            CreateFileWithSaveFilePanelAndCustomExtension(DefaultFolderName, DefaultFileName, file, FormatLog, CustomExtension);

            // Compile
            AssetDatabase.Refresh();

        }

    }
}