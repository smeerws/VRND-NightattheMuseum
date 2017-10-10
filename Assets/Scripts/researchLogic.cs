using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class researchLogic : MonoBehaviour {

	public GameObject rqcontainer;
	string[] rqs;
	bool switchText;

	// Use this for initialization
	void Start () {
		rqs = initRQs ();
		rqcontainer.gameObject.GetComponent<Text> ().text = rqs[0];
		switchText = true; 
		Debug.Log ("start research logic");
		//Random.Range(0,5);
	}

	public string[] initRQs(){
		
		string[] rqs = new string[5];
		rqs [0] = " ... we could consider\n that when studying\n perception both,\n neuroscience and\n presence research\n are asking similar\n questions from\n different starting points, ...";
		rqs [1] = "\n\n... investigating virtual\n reality exposure\n therapy (VRET) as a\n viable treatment option\n for anxiety disorders ... ";
		rqs [2] = "Haptics technologies\n provide the next important\n step towards realistically\n simulated\n environments that have\n been envisioned by\n science fiction authors and\n futurists alike.";
		rqs [3] = "Artistic augmented\n reality(ARTAR) is\n a method to add extra\n levels of perceptions\n by including animations,\n music and sound\n to paintings.";
		rqs [4] = "While talking about\n virtual prototyping,\n a commonly asked\n question is\n “What is different\n in VP versus the\n conventional simulation?";

		return rqs;
	}
	
	// Update is called once per frame
	void Update () {
		if (switchText) {
			StartCoroutine (showNextText (Random.Range(0, 5)));
		}

	}

	IEnumerator showNextText(int index){
		Debug.Log ("in swtich text");
		switchText = false;
		yield return new WaitForSeconds (10);
		rqcontainer.gameObject.GetComponent<Text> ().text = rqs[index];
		switchText = !switchText;
	}
}
