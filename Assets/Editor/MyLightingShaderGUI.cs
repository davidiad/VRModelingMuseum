using UnityEngine;
using UnityEditor;

public class MyLightingShaderGUI : ShaderGUI {

	MaterialEditor editor;
	MaterialProperty[] properties;

	public override void OnGUI (MaterialEditor editor, MaterialProperty[] properties) {
		this.editor = editor;
		this.properties = properties;
		DoMain();
	}

	void DoMain() {
		GUILayout.Label("Main Maps", EditorStyles.boldLabel);
		MaterialProperty mainTex = FindProperty ("_MainTex");//, properties);
		//MaterialProperty tint = FindProperty("_Tint");//, properties);
		//GUIContent albedoLabel = new GUIContent(mainTex.displayName, "Albedo (RGB)");
		editor.TexturePropertySingleLine(MakeLabel(mainTex, "Albedo (RGB)"), mainTex, FindProperty("_Tint"));

		DoMetallic ();
		DoSmoothness ();
		DoNormals ();

		editor.TextureScaleOffsetProperty(mainTex);
	}

	void DoNormals () {
		MaterialProperty map = FindProperty("_NormalMap");
		editor.TexturePropertySingleLine(MakeLabel(map), map,map.textureValue ? FindProperty("_BumpScale") : null);
	}

	void DoMetallic () {
		MaterialProperty slider = FindProperty("_Metallic");
		EditorGUI.indentLevel += 2;
		editor.ShaderProperty(slider, MakeLabel(slider));
		EditorGUI.indentLevel -= 2;
	}

	void DoSmoothness () {
		MaterialProperty slider = FindProperty("_Glossiness");
		EditorGUI.indentLevel += 2;
		editor.ShaderProperty(slider, MakeLabel(slider));
		EditorGUI.indentLevel -= 2;
	}

	// Convenience functions

	MaterialProperty FindProperty (string name) {
		return FindProperty(name, properties);
	}

	static GUIContent staticLabel = new GUIContent();

	static GUIContent MakeLabel (string text, string tooltip = null) {
		staticLabel.text = text;
		staticLabel.tooltip = tooltip;
		return staticLabel;
	}

	static GUIContent MakeLabel (
		MaterialProperty property, string tooltip = null
	) {
		staticLabel.text = property.displayName;
		staticLabel.tooltip = tooltip;
		return staticLabel;
	}
}