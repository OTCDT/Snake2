using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
	public Transform TrailMaker;
	public GameObject TrailPrefab;

	[HideInInspector]
	public Trail thegame;
	public GameObject thegame2;

	void Start()
    {
		thegame = thegame2.GetComponent<Trail>();
		thegame.newtime = 1;
		thegame.timeRemaining = 2;
	}

	void Update()
    {
		MakeTrail();
	}

	void MakeTrail()
	{
		Instantiate(TrailPrefab, TrailMaker.position, TrailMaker.rotation);
	}

	void OnTriggerEnter2D(Collider2D hitInfo)
	{
		Trail trail =     hitInfo.GetComponent<Trail>();
		Player2 player2 = hitInfo.GetComponent<Player2>();
		Fuel fuel =       hitInfo.GetComponent<Fuel>();

		if (player2 != null)
		{
			
			Destroy(gameObject);
		}
		if (trail != null)
		{
			
			Destroy(gameObject);
		}
		if (fuel != null)
		{
			thegame.newtime ++;
		}

	}

}
