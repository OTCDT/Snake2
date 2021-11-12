using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    //Declares objects and variables 
    public GameObject player;
    public GameObject moveto;
    public int speed;
    public int turnspeed;
    int speedchange;
    //Start is called at the first frame
    void Start()
    {
        speedchange = speed;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0f) //This makes sure it is not running when the game is paused
        {
                if (Input.GetKey(KeyCode.A)) //When the key is pressed it will rotate the player around itself to the left
                {
                    transform.RotateAround(player.transform.position, Vector3.forward, turnspeed * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.D)) //When the key is pressed it will rotate the player around itself to the right
                {
                    transform.RotateAround(player.transform.position, -Vector3.forward, turnspeed * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.S)) //When the key is pressed it will slow down the player to a lower speed
                {
                    speed = 9;
                }
                else
                {
                    speed = speedchange;
                }
                // Calculate direction vector.
                Vector3 dirction = player.transform.position - moveto.transform.position;

                // Normalize resultant vector to unit Vector.
                dirction = -dirction.normalized;

                // Move in the direction of the direction vector every frame.
                player.transform.position += dirction * Time.deltaTime * speed;
        }
   
    }
}