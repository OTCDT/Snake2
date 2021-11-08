using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    //  public Vector3 startRotation;
    public GameObject player;
    public GameObject moveto;
    public int speed;
    public int turnspeed;

    int speedchange;

    void Start()
    {
        speedchange = speed;
    }
    // Update is called once per frame
    void Update()
    {
    if (Time.timeScale == 0f)
    {

    }
    else
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(player.transform.position, Vector3.forward, turnspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(player.transform.position, -Vector3.forward, turnspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            speed = 8;
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