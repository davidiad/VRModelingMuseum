using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceManager : MonoBehaviour {

	private AudioSource[] allAudioSources;

	void Awake ()
	{
		allAudioSources = FindObjectsOfType (typeof(AudioSource)) as AudioSource[];
	}

	public void StopAllAudio ()
	{
		foreach (AudioSource audioS in allAudioSources) {
			audioS.Stop ();
		}
	}
}
