using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlaybackDrone : MonoBehaviour {
	public AudioSource audio;
	//private bool isrunning = false;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		audio.mute = true; 
		audio.loop = true;
		Debug.Log ("in drounesound----------");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("in drounesound----------");
		if (WaypointMovement.muteDronesound != audio.mute) {
			audio.mute = WaypointMovement.muteDronesound;
		}
		
	}
}
