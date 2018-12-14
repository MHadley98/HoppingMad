using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.SceneManagement;


public class LeaderboardButton : MonoBehaviour
{

    //called when menu button is pressed
    public void ToLeaderboard()
    {
        //return to menu scene
        SceneManager.LoadScene("Leaderboard");

    }

}
