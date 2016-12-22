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
                levelFailed(GameController.);
                currentLevelFailedFlag = true;
            }
        }
        else
        {
            if (currentLevelFailedFlag == false)
            {
                levelRestarted();
                currentLevelFailedFlag = true;
            }
        }

        
	}

    void levelFailed(int )
    {


    }
    void levelRestarted()
    {


    }
}
