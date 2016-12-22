using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentLevelRestarter : MonoBehaviour {


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            levelController.currentLevelFailed = false;
        }
    }
}
