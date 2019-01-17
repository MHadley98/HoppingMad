using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.SceneManagement;


public class MenuButton : MonoBehaviour
{
    public void ToMenu()
    {
        //sends player to menu scene
        SceneManager.LoadScene("Menu");

    }

}
