using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.SceneManagement;


public class PlayButton : MonoBehaviour
{
    public void StartGame()
    {
        //sends player to game scene
        SceneManager.LoadScene("Level");

        //clears score from previous game when button is pressed
        PlayerPrefs.DeleteKey("score");

    }

}
