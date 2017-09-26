using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class definitions : MonoBehaviour {
	private GameObject robot;
	private bool isrunning = false;
	// Use this for initialization
	void Start () {
		robot = GameObject.Find ("Robot Kyle");
		robot.GetComponent<Animation> ().enabled = false;
		Debug.Log (robot.name);
	}
	
	// Update is called once per frame
	void Update () {
		if (WaypointMovement.humanoidrobot && !isrunning) {
			Debug.Log ("W10");
			isrunning = true;
			robot.GetComponent<Animation> ().enabled = true;
		} 

		if (!WaypointMovement.humanoidrobot) {
			Debug.Log ("!W10");
			isrunning = false;
			robot.GetComponent<Animation> ().enabled = false;
		}
		
	}
}
