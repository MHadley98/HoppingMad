﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using statement for unity ui code
using UnityEngine.UI;

public class Lives : MonoBehaviour {

    //variable to track visible text lives
    //public to let us drag and drop in editor
    public Text livesText;

    //variable to track numerical lives
    //private so other scripts don't change it directly
    //Default to 3 when starting
    private int numericalLives = 3;


    // Use this for initialization
    void Start () {

        //get the lives from prefs data base, use default of 3 if no score lives
        //store result in numerical lives variable
        numericalLives = PlayerPrefs.GetInt("lives", 3);

        //update visual lives
        livesText.text = numericalLives.ToString();
    }


    //updates both visual and numerical data when life is lost
    public void LoseLife()
    {

        numericalLives = numericalLives - 1;

        livesText.text = numericalLives.ToString();

    }

   //saves currents lives to player prefs
    public void SaveLives()
    {

        PlayerPrefs.SetInt("lives", numericalLives);

    }

    //deletes data from player prefs so default value is used when new game is started
    [ContextMenu("ResetLives")]
    public void ResetLives()
    {
        PlayerPrefs.DeleteKey("lives");
    }

    //checks to see if player has run out of lives
    public bool IsGameOver()
    {
        if (numericalLives <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
