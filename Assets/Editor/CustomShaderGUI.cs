using UnityEngine;
using UnityEditor;

public class CustomShaderGUI : ShaderGUI
{
	public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties)
	{
		Debug.Log ("Shadery");
		//base.OnGUI(materialEditor, properties);
//		foreach (MaterialProperty property in properties)
//			materialEditor.ShaderProperty(property, property.displayName);


		MaterialProperty _MainTex = ShaderGUI.FindProperty("_MainTex", properties);
		MaterialProperty _UseTwoColors = ShaderGUI.FindProperty("_UseTwoColors", properties);
		MaterialProperty _Color1 = ShaderGUI.FindProperty("_Color1", properties);

		materialEditor.ShaderProperty(_MainTex, _MainTex.displayName);
		materialEditor.ShaderProperty(_UseTwoColors, _UseTwoColors.displayName);
		materialEditor.ShaderProperty(_Color1, _Color1.displayName);

		if (_UseTwoColors.floatValue == 1)
		{
			MaterialProperty _Color2 = ShaderGUI.FindProperty("_Color2", properties);
			materialEditor.ShaderProperty(_Color2, _Color2.displayName);
		}
	}
}