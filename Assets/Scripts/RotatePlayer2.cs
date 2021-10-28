using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer2 : MonoBehaviour
{
    //  public Vector3 startRotation;
    public GameObject player;
    public int speed;



    // Start is called before the first frame update
    void Start()
    {

        //    transform.eulerAngles = startRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(player.transform.position, Vector3.forward, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(player.transform.position, -Vector3.forward, speed * Time.deltaTime);
        }


    }
}
