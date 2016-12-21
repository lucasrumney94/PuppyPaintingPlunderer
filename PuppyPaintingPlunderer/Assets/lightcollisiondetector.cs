using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcollisiondetector : MonoBehaviour
{
    /// <summary>
    /// this script takes the angle of the spotlight and then detects for player collision in the same angle. 
    /// </summary>

    public int numberOfRaycasts;
    public float raycastFrequency; //Hz

    private float spotAngle; //degrees
    private Vector3 forward; 


	// Use this for initialization
	void Start ()
    {
        spotAngle = this.GetComponent<Light>().spotAngle;
        forward = transform.forward;


	}
	
	void FixedUpdate ()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, forward, out hit))
        {
            if (hit.transform.gameObject.tag == "Player")
            {
                Debug.Log("player hit!");
            }
        }	
	}
}
