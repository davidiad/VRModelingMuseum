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
		MaterialProperty mainTex = FindProperty("_MainTex", properties);
		MaterialProperty tint = FindProperty("_Tint", properties);
		GUIContent albedoLabel = new GUIContent(mainTex.displayName, "Albedo (RGB)");
		editor.TexturePropertySingleLine(albedoLabel, mainTex, tint);
		//editor.TexturePropertyMiniThumbnail (new Rect (9, 9, 30, 12), mainTex, "Iconic", "tipsy!");
	}
}