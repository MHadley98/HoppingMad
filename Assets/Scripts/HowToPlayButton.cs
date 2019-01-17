using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.SceneManagement;


public class HowToPlayButton : MonoBehaviour
{
    public void ToHowToPlay()
    {
        //sends player to thr how to play scene
        SceneManager.LoadScene("HowToPlay");

    }

}
