using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using U.Gears.ActionsOn;

namespace U.Gears.Editor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(ActionOnTriggerEnter2D))]
    public class ActionOnTriggerEnter2DInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {

            ActionOnTriggerEnter2D c = (ActionOnTriggerEnter2D)target;

            GUILayout.Space(8);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("enable"), true);
            if (c.enable)
            {
                GUILayout.Space(8);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("damageMask"), true);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("triggersToAction"), true);

                GUILayout.Space(8);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("infinityCount"), true);
                EditorGUI.indentLevel++;
                if (!c.infinityCount)
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("totalActions"), new GUIContent("Count"), true);
                EditorGUI.indentLevel--;

                GUILayout.Space(8);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("minTimeMode"), true);
                EditorGUI.indentLevel++;
                if (c.minTimeMode != ActionOnTriggerEnter2D.MinTimeMode.Disabled)
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("minTime"), new GUIContent("Time"), true);
                EditorGUI.indentLevel--;

                GUILayout.Space(8);
                EditorGUILayout.PropertyField(serializedObject.FindProperty("onTriggerEnter"), true);
            }

            serializedObject.ApplyModifiedProperties();

        }
    }
}


