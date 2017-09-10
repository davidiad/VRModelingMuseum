using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateDisplayInfo
{
	[MenuItem("Assets/Create/Display Info")]
	public static void CreateAsset()
	{
		CustomAssetUtility.CreateAsset<DisplayInfo>();
	}
}
