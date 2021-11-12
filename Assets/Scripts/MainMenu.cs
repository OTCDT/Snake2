using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //This code will load a scene that is chosen in the Onclick()
    public void Loadscene(int lvlNum)
    {
        SceneManager.LoadScene(lvlNum);
        Time.timeScale = 1f; //This resets the Time.timeScale back to default (1)
    }
}
