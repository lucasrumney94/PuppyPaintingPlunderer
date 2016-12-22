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
    private Vector3 raycastDirection;

	// Use this for initialization
	void Start ()
    {
        spotAngle = this.GetComponentInChildren<Light>().spotAngle;


	}
	
	void FixedUpdate ()
    {
        RaycastHit hit;

        for (int i = 0; i < numberOfRaycasts; i++)
        {

            raycastDirection = transform.forward + new Vector3(0.0f, 0.0f, 2*(1 / Mathf.Sin(spotAngle))) + Random.insideUnitSphere;

            raycastDirection = transform.TransformDirection(raycastDirection);

            Debug.DrawRay(transform.position, raycastDirection);

            if (Physics.Raycast(transform.position, raycastDirection, out hit))
            {
                if (hit.collider.tag.Equals("Player"))
                {
                    Debug.Log("player hit!");
                    //Reset Level
                    levelController.currentLevelFailed = true;
                    break;
                }
            }
        }
        

        
	}
}
