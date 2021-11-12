using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    [SerializeField]
    private GameObject fuel; //Declares what the fuel is

    void OnTriggerEnter2D(Collider2D hitInfo) //This runs whenever there is a collision with the fuel
    {
        //This section uses the components on objects in order to determine what object has collided with the fuel
        Player1 player1 = hitInfo.GetComponent<Player1>();
        Player2 player2 = hitInfo.GetComponent<Player2>();
        Wall wall = hitInfo.GetComponent<Wall>();
        Trail trail = hitInfo.GetComponent<Trail>();
        //This part determines what will happen depending on what object has collided with it 
        //At this stage no matter what it will call Remakefuel 
        if (player1 != null)
        {
            Remakefuel();
        }
        else if (player2 != null)
        {
            Remakefuel();
        }
        else if (wall != null)
        {
            Remakefuel();
        }
    }

    void Remakefuel()
    {
        Vector2 Fuelpos = new Vector2(Random.Range(-40f, 40f), Random.Range(-18f, 18f)); //This will randomly determine a set of coordinates within the map
        Instantiate(fuel, Fuelpos, Quaternion.identity); //This will create a new fuel at the random position 
        Destroy(gameObject); //This will delete the current fuel 
    }
}


