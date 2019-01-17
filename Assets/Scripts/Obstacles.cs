using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    //variables to be used to store each objects position
    float x;
    float y;
    Vector3 pos;


    // Use this for initialization
    void Start()
    {
        //Generates a random position to spawn the objects at
        x = Random.Range(-4, 4);
        y = Random.Range(5, 10);
        pos = new Vector3(x, y);
        transform.position = pos;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we collideded with has player script
        Player playerScript = collision.collider.GetComponent<Player>();

        //only do something if the player runs into
        if (playerScript != null)
        {
            //we did hit player so kill them
            playerScript.Kill();
        }
    }
}
