using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigationInro : MonoBehaviour {

	private GameObject navSign;
	private GameObject wp1, wp2, wp3;

	// Use this for initialization
	void Start () {
		navSign = GameObject.Find ("navigation");

		wp1 = GameObject.Find ("Waypoint_w1");
		wp2 = GameObject.Find ("Waypoint_w2");
		wp3 = GameObject.Find ("Waypoint_w3");

		wp1.SetActive (false);
		wp2.SetActive (false);
		wp3.SetActive (false);

	}

	public void startExperience(){
		wp1.SetActive (true);
		wp2.SetActive (true);
		wp3.SetActive (true);
		navSign.SetActive (false);
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
