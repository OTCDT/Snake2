using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public GameObject fuel;

    public Transform Trail1;
    public Transform Trail2;

    public Collider2D Collideron;

    void Start()
    {
        //  SpawnFuel();
        Collideron.enabled = true;
    }

    void SpawnFuel()
    {  
        Vector3 Fuelposition = new Vector3(Random.Range(-48f, 48f), Random.Range(-18f, 18f), 0f);
        Instantiate(fuel, Fuelposition, Quaternion.identity);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player1 player1 = hitInfo.GetComponent<Player1>();
        Player2 player2 = hitInfo.GetComponent<Player2>();
        if (player1 != null)
        {
            Destroy(gameObject);
            SpawnFuel();
        }
        else if (player2 != null)
        {
            Destroy(gameObject);
            SpawnFuel();
        }
    }
}


