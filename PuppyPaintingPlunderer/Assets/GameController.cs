using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static int currentLevel = 2;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    /// <summary>
    /// increments the current level by 1
    /// </summary>
    public static void incrementLevel()
    {
        currentLevel++;
    }
}
