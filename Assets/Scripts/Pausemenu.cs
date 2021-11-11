using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour
{

    public static bool Gameispaused = false;

    public GameObject pausemenuui;

    private float Thetime;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale += 0.00005f;
        }  

        Debug.Log(Time.timeScale);
    }
    
    void Update()
    {
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

    public void Resume()
    {
        pausemenuui.SetActive(false);
        Time.timeScale = Thetime;
        Gameispaused = false;
    }

    void Pause()
    {   
        Thetime = Time.timeScale;
        pausemenuui.SetActive(true);
        Time.timeScale = 0f;
        Gameispaused = true;
    }
}
