using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
    public void TakeDamage (int damage)
    {
        SceneManager.LoadScene(2);
    }
}
