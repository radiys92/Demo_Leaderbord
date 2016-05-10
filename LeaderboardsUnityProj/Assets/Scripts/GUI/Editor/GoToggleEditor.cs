using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

[CustomEditor(typeof (GoToggle), true)]
[CanEditMultipleObjects]
public class GoToggleEditor : ToggleEditor
{
    private SerializedProperty m_OnValueChangedProperty;
    private SerializedProperty m_TransitionProperty;
    private SerializedProperty m_GraphicProperty;
    private SerializedProperty m_GroupProperty;
    private SerializedProperty m_IsOnProperty;

    protected override void OnEnable()
    {
        base.OnEnable();
        this.m_TransitionProperty = this.serializedObject.FindProperty("toggleTransition");
        this.m_GraphicProperty = this.serializedObject.FindProperty("_TargetGo");
        this.m_GroupProperty = this.serializedObject.FindProperty("m_Group");
        this.m_IsOnProperty = this.serializedObject.FindProperty("m_IsOn");
        this.m_OnValueChangedProperty = this.serializedObject.FindProperty("onValueChanged");
    }

    /// <summary>
    /// 
    /// <para>
    /// See Editor.OnInspectorGUI.
    /// </para>
    /// 
    /// </summary>
    public override void OnInspectorGUI()
    {
        this.serializedObject.Update();
        EditorGUILayout.PropertyField(this.m_IsOnProperty);
        EditorGUILayout.PropertyField(this.m_TransitionProperty);
        EditorGUILayout.PropertyField(this.m_GraphicProperty);
        EditorGUILayout.PropertyField(this.m_GroupProperty);
        EditorGUILayout.Space();
        EditorGUILayout.PropertyField(this.m_OnValueChangedProperty);
        this.serializedObject.ApplyModifiedProperties();
    }
}