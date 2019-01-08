using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we collideded with has player script
        Player playerScript = collision.collider.GetComponent<Player>();

        //only do something if the player runs into
        if (playerScript != null)
        {
            //we did hit player
            playerScript.Kill();
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
