using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Script_04_09 : MonoBehaviour
{
    [SerializeField]
    private int id;
    [SerializeField]
    private GameObject[] targets;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Script_04_09))]
public class ScriptInsector : Editor
{
    public override void OnInspectorGUI()
    {
        //������������
        serializedObject.Update();
        //��ȡ������Ϣ
        SerializedProperty property = serializedObject.FindProperty("id");
        //��ֵ����
        property.intValue = EditorGUILayout.IntField("����", property.intValue);
        //��Ĭ����ʽ������������
        EditorGUILayout.PropertyField(serializedObject.FindProperty("targets"), true);
        //ȫ����������
        serializedObject.ApplyModifiedProperties();
    }
}
#endif