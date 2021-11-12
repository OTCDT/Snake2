using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour
{
    //Declares objects and variables 
    public static bool Gameispaused = false;
    public GameObject pausemenuui;
    private float Thetime;
    //FixedUpdate function runs at a fixed interval
    void FixedUpdate()
    {
        if (Time.timeScale != 0) //This makes sure it is not running when the game is paused
        {
            Time.timeScale += 0.00005f; //The is the speed up feature
        }

        Debug.Log(Time.timeScale);
    }
    // Update is called once per frame
    void Update()
    {   //When escape is pressed it will toggle the pause menu 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Gameispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    //Resumes the game
    public void Resume()
    {
        pausemenuui.SetActive(false); //Deactivates the pause panel 
        Time.timeScale = Thetime; //Resumes time
        Gameispaused = false; //Says that the game isn’t paused
    }
    //Pauses the game
    void Pause()
    {   
        Thetime = Time.timeScale; //Gets time before pause
        pausemenuui.SetActive(true); //Activates the pause panel 
        Time.timeScale = 0f; //Stops time
        Gameispaused = true; //Says that the game is paused
    }
}
