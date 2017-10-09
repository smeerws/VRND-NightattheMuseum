using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoPlayback : MonoBehaviour {
	private string dronemovie     = "drone-fade.mp4";
	private string robotworkmovie = "proftrainingrobot.mp4";
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

	public void startdroneVideo(){
		StartCoroutine (streamVideo(dronemovie));
		Debug.Log ("Coroutine started");
	}

	public void startrobotworkVideo(){
		StartCoroutine (streamVideo(robotworkmovie));
		Debug.Log ("Coroutine started");
	}

//	public void startdroneVideo(){
//		StartCoroutine (streamVideo(dronemovie));
//		Debug.Log ("Coroutine started");
//	}
}
