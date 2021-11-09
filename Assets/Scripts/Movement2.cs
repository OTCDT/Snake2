using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    //  public Vector3 startRotation;
    public GameObject player;
    public GameObject moveto;
    public int speed;
    public int turnspeed;

    int speedchange;
    // Update is called once per frame
    void Start()
    {
        speedchange = speed;
    }

    void Update()
    {
    if (Time.timeScale == 0f)
    {

    }
    else
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(player.transform.position, Vector3.forward, turnspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(player.transform.position, -Vector3.forward, turnspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
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
