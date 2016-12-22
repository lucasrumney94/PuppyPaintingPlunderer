using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Once a player's head collide with the door collider, give feedback -> highlight door 
public class doorEnter : MonoBehaviour {

	[SerializeField]
	private Transform playerTransform;

	[SerializeField]
	private GameObject doorHighlight;




	void start() {
		playerTransform = GameObject.FindGameObjectWithTag ("MainCamera").transform;
		doorHighlight = GameObject.FindGameObjectWithTag ("Highlight");
	}

	void update() {
 		
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag.Equals ("MainCamera")) {
			doorHighlight.SetActive(true);
		}
	}
}
