using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoPlayback : MonoBehaviour {
	private string movie = "drone-fade.mp4";
	public int sceneNumber; 

	// Use this for initialization
	void Start () {
		//StartCoroutine (streamVideo(movie));
	}
	
	private IEnumerator streamVideo(string video){
		Handheld.PlayFullScreenMovie (video, Color.black, FullScreenMovieControlMode.CancelOnInput, FullScreenMovieScalingMode.AspectFill);
		yield return new WaitForEndOfFrame ();
		Debug.Log ("Video playback is now completed");
		//SceneManager.LoadScene (sceneNumber);
	}

	public void startVideo(){
		StartCoroutine (streamVideo(movie));
		Debug.Log ("Coroutine started");
	}
}
