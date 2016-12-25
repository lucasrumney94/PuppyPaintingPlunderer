using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelController : MonoBehaviour {


    [SerializeField]
    public static bool currentLevelFailed = false;

    [SerializeField]
    private bool currentLevelFailedFlag = false;

    private List<List<GameObject>> listOfLevelFailObjects;

    // Use this for initialization
    void Start()
    {
        listOfLevelFailObjects = new List<List<GameObject>>();
        for (int i = 0; i < 6; i++)
        {
            listOfLevelFailObjects.Add(new List<GameObject>(GameObject.FindGameObjectsWithTag("fail" + GameController.currentLevel)));
            foreach (GameObject g in listOfLevelFailObjects[i])
            {
                g.SetActive(false);
                Debug.Log(g.name + " hidden initially");
            }
        }

        
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
        Debug.Log("level Failed!");
        
        foreach (GameObject g in listOfLevelFailObjects[currentLevel])
        {
            Debug.Log(g.name + " shown on failure");
            g.SetActive(true);
        }

    }
    void levelRestarted(int currentLevel)
    {
        foreach (GameObject g in listOfLevelFailObjects[currentLevel - 1])
        {
            g.SetActive(false);
            Debug.Log(g.name + " hidden on restart");
        }

    }
}
