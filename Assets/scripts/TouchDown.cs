using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDown : MonoBehaviour {

	public GameObject camContainer;
	public GameObject go;

	void Start () {
		Debug.Log ("Start in TouchDown");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log(">>>>>>>>>>>>>>>>");
			Debug.Log ("Input.GetMouseButtonDown (0)");
			Debug.Log ("cam pos: " + camContainer.transform.position);
			Debug.Log ("go pos: " + go.transform.position);
			Debug.Log ("__________");
			//			_state = _state == State.Focused ? State.Clicked : _state;

//			_audio_source.Play ();

			camContainer.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.z);
			//camCon.transform.SetPositionAndRotation (go.transform.position, Quaternion.identity);
			//go.transform.position = new Vector3 (go.transform.position.x + 0.01f, go.transform.position.y, go.transform.position.z);
		}
	}
}
