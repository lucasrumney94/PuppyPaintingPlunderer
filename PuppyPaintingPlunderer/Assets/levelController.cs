using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelController : MonoBehaviour {


    [SerializeField]
    public static bool currentLevelFailed = false;

    [SerializeField]
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
            if (currentLevelFailedFlag == true)
            {
                levelRestarted(GameController.currentLevel);
                currentLevelFailedFlag = false;
            }
        }

        
	}

    void levelFailed(int currentLevel)
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("fail" + currentLevel.ToString()))
        {

            Debug.Log(g.name + " shown on failure");
            g.SetActive(true);
        }

    }
    void levelRestarted(int currentLevel)
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("fail" + currentLevel.ToString()))
        {
            g.SetActive(false);
            Debug.Log(g.name + " hidden on restart");
        }

    }
}
