using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play: MonoBehaviour
{
    public void Playbutton() // simple play button function
    {
        SceneManager.LoadScene(0);// on click it will open the gamescene
    }
}