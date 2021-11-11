using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    [SerializeField]
    private GameObject fuel;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player1 player1 = hitInfo.GetComponent<Player1>();
        Player2 player2 = hitInfo.GetComponent<Player2>();
        Wall wall = hitInfo.GetComponent<Wall>();
        Trail trail = hitInfo.GetComponent<Trail>();

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
        Vector2 Fuelpos = new Vector2(Random.Range(-40f, 40f), Random.Range(-18f, 18f));
        Instantiate(fuel, Fuelpos, Quaternion.identity);
        Destroy(gameObject);
    }
}


