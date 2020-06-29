using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;

using UnityEditor;

using UnityEngine;

namespace Mochizuki.VariationPackager
{
    internal class GlobDebugger : EditorWindow
    {
        [SerializeField]
        private List<string> _excludes;

        [SerializeField]
        private List<string> _includes;

        private List<string> _matches;

        private Vector2 _scrollPosition;

        [MenuItem("Mochizuki/Variation Packager/Glob Debugger")]
        public static void ShowWindow()
        {
            var window = GetWindow<GlobDebugger>();
            window.titleContent = new GUIContent("Glob Debugger");

            window.Show();
        }

        public void OnGUI()
        {
            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Glob Debugger");

            _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition, false, false);

            var self = new SerializedObject(this);
            self.Update();

            EditorGUILayout.PropertyField(self.FindProperty("_includes"), true);
            EditorGUILayout.PropertyField(self.FindProperty("_excludes"), true);

            self.ApplyModifiedProperties();

            if (GUILayout.Button("Debug")) OnDebug();

            EditorGUILayout.Space();

            EditorGUI.BeginDisabledGroup(true);

            EditorGUILayout.LabelField("Results : ");

            foreach (var path in _matches)
            {
                var asset = AssetDatabase.LoadAssetAtPath<Object>(path);
                EditorGUILayout.ObjectField("Asset", asset, typeof(Object), false);
            }

            EditorGUI.EndDisabledGroup();

            EditorGUILayout.EndScrollView();
        }

        private void OnDebug()
        {
            var matcher = new Matcher();
            matcher.AddExclude("**/*.meta");
            matcher.AddIncludePatterns(_includes);
            matcher.AddExcludePatterns(_excludes);

            var rootDirectory = new DirectoryInfoWrapper(new DirectoryInfo(Application.dataPath));

            _matches.Clear();
            _matches.AddRange(matcher.Execute(rootDirectory).Files.Select(w => $"Assets/{w.Path}"));
        }
    }
}