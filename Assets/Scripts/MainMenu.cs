using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Loadscene(int lvlNum)
    {
        SceneManager.LoadScene(lvlNum);
    }
}
