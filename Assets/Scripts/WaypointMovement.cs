﻿using UnityEngine;
using System.Collections;

public class WaypointMovement : MonoBehaviour {
	
	public GameObject player;
	public static bool mutePostersound;
	public static bool mutehumanoidrobot;
	public static bool muteDronesound;
	public static bool muteAIsound;


	public float height = 2;
	public bool teleport = true;

	public float maxMoveDistance = 10;
	//private bool moving = false;

	// Use this for initialization
	void Start () {
		mutePostersound    = true;
		mutehumanoidrobot  = true;
		muteDronesound     = true; 
		muteAIsound        = true; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Move(GameObject waypoint) {
		if (!teleport) {
			iTween.MoveTo (player, 
				iTween.Hash (
					"position", new Vector3 (waypoint.GetComponent<Transform> ().position.x, waypoint.GetComponent<Transform> ().position.y + height / 2, waypoint.GetComponent<Transform> ().position.z), 
					"time", .2F, 
					"easetype", "linear"
				)
			);

			mutePostersound = true;
			mutehumanoidrobot = true;
			muteAIsound = true; 

			if (waypoint.name == "Waypoint_w5" || waypoint.name == "Waypoint_w4") {
				mutePostersound = false;
			} else if (waypoint.name == "Waypoint_w10") {
				mutehumanoidrobot = false;
			} else if (waypoint.name == "Waypoint_w12") {
				muteAIsound = false; 
			} else if (waypoint.name == "Waypoint_w9") {
				muteDronesound = false;
				} 

		} else {
			player.transform.position = new Vector3 (waypoint.GetComponent<Transform> ().position.x, waypoint.GetComponent<Transform> ().position.y + height / 2, waypoint.GetComponent<Transform> ().position.z);
		}
	}

}

