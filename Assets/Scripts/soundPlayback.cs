using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlayback : MonoBehaviour {

	AudioSource scifi_audio, defs_audio, ai_audio, drone_audio, tele_audio, research_audio, presence_audio, train_audio; 
	private bool isrunning = false;

	public AudioClip posterClip1;
	public AudioClip posterClip2;

	// Use this for initialization
	void Start () {
		scifi_audio = GameObject.Find ("posterwall").GetComponent<AudioSource>();
		scifi_audio.mute = true;
//		defs_audio, 
		ai_audio = GameObject.Find("ai").GetComponent<AudioSource>(); 
//		drone_audio, 
		tele_audio = GameObject.Find("telepresence").GetComponent<AudioSource>(); 
		research_audio = GameObject.Find("researchwall").GetComponent<AudioSource>(); 
		presence_audio = GameObject.Find("improvepresence").GetComponent<AudioSource>();
//		train_audio; 
	}
	
	// Update is called once per frame
	void Update () {
		//Posterwall Sci-fi
		//player on wpposterwall and audio isn't started yet.
		if (!WaypointMovement.mutePostersound && !isrunning) {
			StartCoroutine (playNextSound ());
			isrunning = !isrunning;
			Debug.Log ("started poster sound" + WaypointMovement.mutePostersound);
		} else if (WaypointMovement.mutePostersound != scifi_audio.mute) {
			//scifi_audio.Pause ();
			scifi_audio.mute = !scifi_audio.mute;
			Debug.Log ("paused poster sound" + WaypointMovement.mutePostersound);
			//isrunning = false;
		} 

		muteAIsound ();
		muteTelesound ();
		mutePresencesound ();
		muteResearchsound ();
	}

	IEnumerator playNextSound(){
		Debug.Log ("playsound " + WaypointMovement.mutePostersound);
		scifi_audio.clip = posterClip1;
		scifi_audio.Play ();
		yield return new WaitForSeconds (scifi_audio.clip.length);
		scifi_audio.clip = posterClip2;
		scifi_audio.Play ();
	}

	private void muteAIsound(){
		if (WaypointMovement.muteAIsound != ai_audio.mute) {
			ai_audio.mute = WaypointMovement.muteAIsound;
		}
	}

	private void muteTelesound(){
		if (WaypointMovement.muteTelesound != tele_audio.mute) {
			tele_audio.mute = WaypointMovement.muteTelesound;
		}
	}

	private void mutePresencesound(){
		if (WaypointMovement.mutePresencesound != presence_audio.mute) {
			presence_audio.mute = WaypointMovement.mutePresencesound;
		}
	}

	private void muteResearchsound(){
		if (WaypointMovement.muteResearchsound != research_audio.mute) {
			research_audio.mute = WaypointMovement.muteResearchsound;
		}
	}
}
