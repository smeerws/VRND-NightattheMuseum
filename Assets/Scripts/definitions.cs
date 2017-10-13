using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class definitions : MonoBehaviour {
	private GameObject robot;
	private bool defActive, welcomeActive;
	private GameObject btnVR, btnRobot, btnTele, btnAR, btnAI;
	public  GameObject vrplane, robotplane, teleplane, arplane, aiplane, welcomeplane;
	private GameObject active;

	// Use this for initialization
	void Start () {
		robot = GameObject.Find ("Robot Kyle");
		robot.GetComponent<Animation> ().enabled = false;

		btnRobot = GameObject.Find ("btnRobot");
		btnTele  = GameObject.Find ("btnTele");
		btnVR    = GameObject.Find ("btnVR");
		btnAR    = GameObject.Find ("btnAR");
		btnAI    = GameObject.Find ("btnAI");

		vrplane.SetActive(false);
		robotplane.SetActive (false);
		teleplane.SetActive (false);
		arplane.SetActive (false);
		aiplane.SetActive (false);
		welcomeplane.SetActive (true);

		defActive = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (defActive) {
			if (!active.GetComponent<AudioSource> ().isPlaying) {
				active.gameObject.SetActive (false);
				welcomeplane.SetActive (true);
				robot.GetComponent<Animation> ().enabled = false;
				setButtonsActive ();
				defActive = false;
				muteInactiveDefs ();
			} 
		}	
	}
		

	private void startDefinition(GameObject current){
		active = current;
		active.gameObject.SetActive (true);
		welcomeplane.SetActive (false);
		defActive = true;

		robot.GetComponent<Animation> ().enabled = true;
		setButtonsInactive ();
	}

	public void startVR(){
		startDefinition (vrplane);
	}

	public void startAR(){
		startDefinition(arplane);
		}

	public void startTele(){
		startDefinition (teleplane);
		}

	public void startRobot(){
		startDefinition (robotplane);
		}

	public void startAI(){
		startDefinition (aiplane);
	}

	private void muteInactiveDefs(){
		vrplane.GetComponent<AudioSource> ().mute    = !vrplane.activeSelf;
		arplane.GetComponent<AudioSource> ().mute    = !arplane.activeSelf;
		robotplane.GetComponent<AudioSource> ().mute = !robotplane.activeSelf;
		teleplane.GetComponent<AudioSource> ().mute  = !teleplane.activeSelf;
		aiplane.GetComponent<AudioSource> ().mute    = !aiplane.activeSelf;

	}



	private void setButtonsInactive(){
		btnRobot.GetComponent<Button> ().interactable = false;
		btnTele.GetComponent<Button> ().interactable  = false;
		btnVR.GetComponent<Button> ().interactable    = false;
		btnAR.GetComponent<Button> ().interactable    = false;
		btnAI.GetComponent<Button> ().interactable    = false;
	}

	private void setButtonsActive(){
		btnRobot.GetComponent<Button> ().interactable = true;
		btnTele.GetComponent<Button> ().interactable  = true;
		btnVR.GetComponent<Button> ().interactable    = true;
		btnAR.GetComponent<Button> ().interactable    = true;
		btnAI.GetComponent<Button> ().interactable    = true;
	}
}
