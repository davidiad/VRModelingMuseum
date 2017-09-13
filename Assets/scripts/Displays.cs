using System.Collections.Generic;
using UnityEngine;
using System.Collections;



public class Displays: ScriptableObject
{
	public List <DisplayInfo> DisplayItems;

	public void AddDisplay() {
		DisplayInfo displayInfo = new DisplayInfo ();
		DisplayItems.Add (displayInfo);
	}
}
	
