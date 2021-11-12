using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class settingsmenu : MonoBehaviour
{
    //Declares objects and variables 
    public AudioMixer audioMixer;

    public void Setvolume (float volume)
    {
        audioMixer.SetFloat("volume", volume); //changes the volume based on a slider
    }
}
