using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderrotation : MonoBehaviour {

	public GameObject cylinder1;
	public GameObject cylinder2;
	public GameObject cylinder3;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		cylinder1.transform.Rotate (Vector3.up*10*Time.deltaTime);
		cylinder2.transform.Rotate (Vector3.up*10*Time.deltaTime);
		cylinder3.transform.Rotate (Vector3.up*10*Time.deltaTime);
	}
}
