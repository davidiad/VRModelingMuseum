using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DisplayInfo // : ScriptableObject
{
	public int displayNumber;
	public string title;
	[TextArea(9, 7)]
	public string textInfo;
	public Color bgColor;
	public AudioClip PlayBackSoundFile;
}
