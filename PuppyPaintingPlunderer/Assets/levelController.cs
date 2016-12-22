using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelController : MonoBehaviour {

    public static bool currentLevelFailed = false;

    private bool currentLevelFailedFlag = false;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (currentLevelFailed == true)
        {
            if (currentLevelFailedFlag == false)
            {
                levelFailed(GameController.currentLevel);
                currentLevelFailedFlag = true;
            }
        }
        else
        {
            if (currentLevelFailedFlag == false)
            {
                levelRestarted(GameController.currentLevel);
                currentLevelFailedFlag = true;
            }
        }

        
	}

    void levelFailed(int currentLevel)
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("fail" + currentLevel.ToString()))
        {
            g.SetActive(true);
        }

    }
    void levelRestarted(int currentLevel)
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("fail" + currentLevel.ToString()))
        {
            g.SetActive(false);
        }

    }
}
