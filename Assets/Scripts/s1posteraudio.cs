using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class s1posteraudio : MonoBehaviour {
	public AudioClip startClip;
	public AudioClip nextClip;
	private AudioSource audio;
	private bool isrunning = false;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		audio.loop = true;
	}

	void Update(){
		Debug.Log ("update poster" + WaypointMovement.mutePostersound);
		if (!WaypointMovement.mutePostersound && !isrunning) {
			StartCoroutine (playNextSound ());
			isrunning = true;
		} 
		if (WaypointMovement.mutePostersound) {
			isrunning = false;
			audio.Pause ();
		}
	}

	IEnumerator playNextSound(){
		    Debug.Log ("playsound " + WaypointMovement.mutePostersound);
			audio.clip = startClip;
			audio.Play ();
			yield return new WaitForSeconds (audio.clip.length);
			audio.clip = nextClip;
			audio.Play ();
		}

}
