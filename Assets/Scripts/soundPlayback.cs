using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlayback : MonoBehaviour {

	AudioSource scifi_audio, ai_audio, drone_audio, tele_audio, research_audio, presence_audio, train_audio; 
	AudioSource defs_audio_vrplane, defs_audio_arplane, defs_audio_robotplane, defs_audio_teleplane, defs_audio_aiplane; 
	private bool isrunning = false;

	public AudioClip posterClip1;
	public AudioClip posterClip2;

	// Use this for initialization
	void Start () {
		scifi_audio = GameObject.Find ("posterwall").GetComponent<AudioSource>();
		defs_audio_vrplane = GameObject.Find("VRPlane").GetComponent<AudioSource>(); 
		defs_audio_arplane = GameObject.Find("ARPlane").GetComponent<AudioSource>();
		defs_audio_robotplane = GameObject.Find("RobotPlane").GetComponent<AudioSource>();
		defs_audio_teleplane = GameObject.Find("TelepresencePlane").GetComponent<AudioSource>();
		defs_audio_aiplane = GameObject.Find("AIPlane").GetComponent<AudioSource>();
		ai_audio = GameObject.Find("ai").GetComponent<AudioSource>(); 
//		drone_audio, 
		tele_audio = GameObject.Find("telepresence").GetComponent<AudioSource>(); 
		research_audio = GameObject.Find("researchwall").GetComponent<AudioSource>(); 
		presence_audio = GameObject.Find("improvepresence").GetComponent<AudioSource>();
//		train_audio; 
	}
	
	// Update is called once per frame
	void Update () {
 
		muteSciFisound ();
		muteDefsound ();
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

	private void muteSciFisound(){
		//Posterwall Sci-fi
		//player on wpposterwall and audio isn't started yet.
		if (!WaypointMovement.mutePostersound && !isrunning) {
			StartCoroutine (playNextSound ());
			isrunning = !isrunning;
			Debug.Log ("started poster sound" + WaypointMovement.mutePostersound);
		} else if (WaypointMovement.mutePostersound != scifi_audio.mute) {
			scifi_audio.mute = !scifi_audio.mute;
			Debug.Log ("paused poster sound" + WaypointMovement.mutePostersound);
		}
	}

	private bool muteDefsaudio(){
		return defs_audio_vrplane.mute && defs_audio_arplane.mute && defs_audio_robotplane.mute && defs_audio_teleplane.mute && defs_audio_aiplane.mute; 
	}

	private void muteDefsound(){
		//Debug.Log ("WaypointMovement.mutehumanoidrobot "+WaypointMovement.mutehumanoidrobot+ " muteDefsaudio() " + muteDefsaudio() );
		if (WaypointMovement.mutehumanoidrobot != muteDefsaudio()) {
			defs_audio_vrplane.mute = defs_audio_arplane.mute = defs_audio_robotplane.mute = defs_audio_teleplane.mute = defs_audio_aiplane.mute = WaypointMovement.mutehumanoidrobot;
		}
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
