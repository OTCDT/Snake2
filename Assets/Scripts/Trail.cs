using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{

	public float timeRemaining;
	public float newtime;
	
	
	void Start()
    {
		timeRemaining += newtime;
    }

	void Update()
	{
		if (timeRemaining > 0)
		{
			timeRemaining -= Time.deltaTime;
			Debug.Log(timeRemaining);
		}
		else if (timeRemaining < 0)
		{
			Destroy(gameObject);
			Debug.Log("gone");
		}
	}

}