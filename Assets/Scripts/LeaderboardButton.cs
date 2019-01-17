using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.SceneManagement;


public class LeaderboardButton : MonoBehaviour
{
    public void ToLeaderboard()
    {
        //sends player to leaderboard scene
        SceneManager.LoadScene("Leaderboard");

    }

}
