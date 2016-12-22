using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Transform player to next level enter door position once collides with doorknob
public class doorKnobEnter : MonoBehaviour {
	[SerializeField]
	private GameObject nextLevelDoor;

	[SerializeField]
	private GameObject player;

	private Vector3 nextLevelDoorPosition; 


	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		nextLevelDoorPosition = nextLevelDoor.transform.position;

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag.Equals ("MainCamera")) {
			player.transform.position = nextLevelDoorPosition;
			Debug.Log("Sould enter Room2");
		}
	}
	

}
