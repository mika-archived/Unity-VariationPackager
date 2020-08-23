/*-------------------------------------------------------------------------------------------
 * Copyright (c) Fuyuno Mikazuki / Natsuneko. All rights reserved.
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *------------------------------------------------------------------------------------------*/

using System.IO;
using System.Linq;

using Mochizuki.VariationPackager.Models.Interface;

using UnityEditor;

using UnityEngine;
using UnityEngine.SceneManagement;

using PackageJson = Mochizuki.VariationPackager.Models.Json.Package;

namespace Mochizuki.VariationPackager
{
    internal class Packaging : EditorWindow
    {
        private bool _isKeepUnityPackage;
        private string _packageJsonPath;

        [MenuItem("Mochizuki/Variation Packager/Packaging")]
        public static void ShowWindow()
        {
            var window = GetWindow<Packaging>();
            window.titleContent = new GUIContent("Variation Packager");

            window.Show();
        }

        public void OnEnable()
        {
            _packageJsonPath = Path.Combine(Application.dataPath, "package.json");
        }

        public void OnGUI()
        {
            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Create a packages from Assets/package.json or Script Configuration in current scene.");
            EditorGUILayout.LabelField("Priority: Assets/package.json > Script Configuration");

            EditorGUILayout.Space();

            EditorGUIUtility.labelWidth = 275;
            _isKeepUnityPackage = EditorGUILayout.Toggle("Keep a UnityPackage when create Zip Archive", _isKeepUnityPackage);

            EditorGUI.BeginDisabledGroup(!IsExistsPackageJson() && !IsExistsScriptConfiguration());

            if (GUILayout.Button("Create Packages"))
            {
                EditorUtility.DisplayProgressBar("Creating packages...", "", 0.0f);
                CLI.CreatePackage(_packageJsonPath, _isKeepUnityPackage);
                EditorUtility.ClearProgressBar();
            }

            EditorGUI.EndDisabledGroup();
        }

        private bool IsExistsPackageJson()
        {
            return File.Exists(_packageJsonPath);
        }

        private static bool IsExistsScriptConfiguration()
        {
            var objects = SceneManager.GetActiveScene().GetRootGameObjects();
            return objects.Any(w => w.GetComponentInChildren<IPackage>() != null);
        }
    }
}