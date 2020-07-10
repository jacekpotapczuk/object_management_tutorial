using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(FloatRange)), CustomPropertyDrawer(typeof(IntRange))]
public class FloatOrIntRangeDrawer : PropertyDrawer {

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		int origianlIndentLevel = EditorGUI.indentLevel;
		float originaLabelWidth = EditorGUIUtility.labelWidth;

		EditorGUI.BeginProperty(position, label, property);
		position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive) ,label);
		position.width = position.width / 2f;
		EditorGUIUtility.labelWidth = position.width / 2f;
		EditorGUI.indentLevel = 1;
		EditorGUI.PropertyField(position, property.FindPropertyRelative("min"));
		position.x += position.width;
		EditorGUI.PropertyField(position, property.FindPropertyRelative("max"));
		EditorGUI.EndProperty();

		EditorGUI.indentLevel = origianlIndentLevel;
		EditorGUIUtility.labelWidth = originaLabelWidth;
	}
}
