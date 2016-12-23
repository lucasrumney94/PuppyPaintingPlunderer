using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blinkoffText : MonoBehaviour {

    public float timeToBlinkOff = 2.0f;
    public int blinkLength = 5000; 
    private Text blinkText;

    private bool[] truefalse;

	// Use this for initialization
	void Start ()
    {
        blinkText = this.GetComponent<Text>();
        truefalse = new bool[2];
        truefalse[0] = true;
        truefalse[1] = false;



        StartCoroutine(BlinkOffAfterTime(timeToBlinkOff));
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    IEnumerator BlinkOffAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        for (int i = 0; i < blinkLength; i++)
        {
            Debug.Log(Random.Range(0, 2));
            blinkText.enabled = truefalse[Random.Range(0, 2)];
        }
        blinkText.enabled = false;
    }

}
