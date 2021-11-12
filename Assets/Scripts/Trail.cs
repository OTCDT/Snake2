using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
	//Declares variables 
	public float timeRemaining;
	public float newtime;
	//Start is called at the first frame
	void Start()
    {
		timeRemaining += newtime; //newtime is affected by the Player script for increasing trail length
	}
	// Update is called once per frame
	void Update()
	{   //This is a timer for how long the trail exists before getting deleted 
		if (timeRemaining > 0)
		{
			timeRemaining -= Time.deltaTime;
		}
		else if (timeRemaining < 0)
		{
			Destroy(gameObject);
		}
	}

}

