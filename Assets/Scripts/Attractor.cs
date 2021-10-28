using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{

	// the script has been edited a little but is still very similar to the original post
	public float speed;
	public GameObject object1; // The game object that moves.
	public GameObject object2; // the game object that Object 1 moves to.

	void FixedUpdate()
	{
		// Calculate direction vector.
		Vector3 dirction = object1.transform.position - object2.transform.position;

		// Normalize resultant vector to unit Vector.
		dirction = -dirction.normalized;

		// Move in the direction of the direction vector every frame.
		object1.transform.position += dirction * Time.deltaTime * speed;
	}
}