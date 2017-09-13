using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Displays))]
public class DisplaysEditor : Editor 
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector ();
		Displays _displays = (Displays)target as Displays;

		EditorGUILayout.Space();
		EditorGUILayout.Space();
//		GUILayout.BeginHorizontal();
//		GUILayout.Label(" Grid Width ");
//		EditorGUILayout.FloatField(50f, GUILayout.Width(50f));
//		GUILayout.EndHorizontal();

		GUILayout.BeginVertical ();
		GUILayout.Label("Displays", EditorStyles.boldLabel);
		for (int i = 0; i < _displays.DisplayItems.Count; i++) {
			EditorGUILayout.Space();
			GUILayout.BeginVertical ("Box");
			DisplayInfo _displayItem = _displays.DisplayItems [i];
			_displayItem.displayNumber = i + 1;
			string displayNumText = "Display #" + _displayItem.displayNumber;
			EditorGUILayout.LabelField (displayNumText, EditorStyles.largeLabel);
			EditorGUILayout.Space();
			EditorGUILayout.Space();
			//_displayItem.displayNumber = EditorGUILayout.IntField(displayNumText, _displayItem.displayNumber);
			_displayItem.title = EditorGUILayout.TextField ("Title", _displayItem.title);

//			if (_displayItem.textInfo == "" )
//				_displayItem.textInfo = "Description default";

			GUIStyle areaStyle = new GUIStyle(GUI.skin.textArea);
			areaStyle.wordWrap = true;


			GUILayout.Label("Text");
			//EditorGUI.TextArea(new Rect(30, 300, 200, 100), _displayItem.textInfo);
			_displayItem.textInfo = EditorGUILayout.TextArea(_displayItem.textInfo, areaStyle, GUILayout.MinHeight(100));
			//_displayItem.textInfo = EditorGUILayout.TextArea ("Description Label", _displayItem.textInfo, GUILayout.Height(124), GUILayout.MaxHeight(75), GUILayout.MaxWidth(180));
//			serializedObject.ApplyModifiedProperties ();

			//color
			GUILayout.BeginHorizontal();
			GUILayout.Label("Background Color");
			_displayItem.bgColor = EditorGUILayout.ColorField(_displayItem.bgColor);
			GUILayout.EndHorizontal();

//			Vector2 scroll = EditorGUILayout.BeginScrollView(scroll);
//			_displayItem.title = EditorGUILayout.TextArea(_displayItem.title, GUILayout.Height(position.height - 30));
//			EditorGUILayout.EndScrollView();

			//audio clip
			_displayItem.PlayBackSoundFile = EditorGUILayout.ObjectField("Sound Clip", _displayItem.PlayBackSoundFile, typeof(AudioClip)) as AudioClip;
			EditorGUILayout.Space();
			GUILayout.EndVertical ();
			EditorGUILayout.Space();
		}
		GUILayout.EndVertical();


		// Add Button
		if (GUILayout.Button("Add Display")) {
			_displays.AddDisplay ();
		}


//		_displays.DisplayItems[0] = EditorGUILayout.IntField("Experience", myTarget.experience);
//		EditorGUILayout.LabelField("Level", myTarget.Level.ToString());
	}
}