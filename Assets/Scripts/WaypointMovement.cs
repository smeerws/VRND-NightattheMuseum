using UnityEngine;
using System.Collections;

public class WaypointMovement : MonoBehaviour {
	
	public GameObject player;
	public static bool mutePostersound;
	public static bool humanoidrobot;


	public float height = 2;
	public bool teleport = true;

	public float maxMoveDistance = 10;
	private bool moving = false;

	// Use this for initialization
	void Start () {
	
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
			Debug.Log (waypoint.name);
			if (waypoint.name == "Waypoint_w5" || waypoint.name == "Waypoint_w4") {
				mutePostersound = true;
			} else {
				mutePostersound = false;
			}
			Debug.Log (mutePostersound);
			if (waypoint.name == "Waypoint_w10") {
				humanoidrobot = true;
			} else {
				humanoidrobot = false;
			}
			Debug.Log ("humanoidrobot: " + humanoidrobot);
		} else {
			player.transform.position = new Vector3 (waypoint.GetComponent<Transform> ().position.x, waypoint.GetComponent<Transform> ().position.y + height / 2, waypoint.GetComponent<Transform> ().position.z);
		}
	}

}

