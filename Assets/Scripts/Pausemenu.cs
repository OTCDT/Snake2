using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour
{

    public static bool Gameispaused = false;

    public GameObject pausemenuui;
    // Update is called once per frame
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

    void Resume()
    {
        pausemenuui.SetActive(false);
        Time.timeScale = 1f;
        Gameispaused = false;
    }

    void Pause()
    {
        pausemenuui.SetActive(true);
        Time.timeScale = 0f;
        Gameispaused = true;
    }
}
