using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
	//Declares objects and variables 
	public Transform TrailMaker;
	public GameObject TrailPrefab;

	[HideInInspector]
	public Trail thegame;
	public GameObject thegame2;
	//Start is called at the first frame
	void Start()
	{
		//Gets another script 
		thegame = thegame2.GetComponent<Trail>();
		thegame.newtime = 0;
		thegame.timeRemaining = 1; //This resets the Time.timeScale back to default (1)
	}
	// Update is called once per frame
	void Update()
	{
		MakeTrail();
	}

	void MakeTrail()
	{
		if (Time.timeScale != 0f) //This makes sure it is not running when the game is paused
		{
			Instantiate(TrailPrefab, TrailMaker.position, TrailMaker.rotation); //Creates a new trail behind the player
		}
	}
	//This runs whenever there is a collision with the player
	void OnTriggerEnter2D(Collider2D hitInfo)
	{
		//This section uses the components on objects in order to determine what object has collided with the player
		Trail trail = hitInfo.GetComponent<Trail>();
		Player1 player1 = hitInfo.GetComponent<Player1>();
		Fuel fuel = hitInfo.GetComponent<Fuel>();
		Wall wall = hitInfo.GetComponent<Wall>();
		
		if (player1 != null)
		{
			SceneManager.LoadScene(4); //Brings up tie menu
			Destroy(gameObject); //Deletes player
		} 
		if (trail != null)
		{
			SceneManager.LoadScene(2); //Brings up player wins menu
			Destroy(gameObject); //Deletes player
		}
		if (fuel != null)
		{
			thegame.newtime += 0.5f; //Increases trail length
		}
		if (wall != null)
		{
			SceneManager.LoadScene(2); //Brings up player wins menu
			Destroy(gameObject); //Deletes player
		}

	}

}
