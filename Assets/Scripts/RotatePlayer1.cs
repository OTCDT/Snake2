using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer1 : MonoBehaviour
{
    //  public Vector3 startRotation;
    public GameObject player;
    public int speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(player.transform.position, Vector3.forward, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(player.transform.position, -Vector3.forward, speed * Time.deltaTime);
        }


    }
}