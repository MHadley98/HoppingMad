using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour {

    //variables to be used to store each objects position
    float x;
    float y;
    Vector3 pos;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we collideded with has either the pickups or obstacles script
        PickUps pickupScript = collision.collider.GetComponent<PickUps>();

        Obstacles obstaclesScript = collision.collider.GetComponent<Obstacles>();

        //do something if there is a collison between the out of bounds area with either an obstacle or pickup
        if (pickupScript)
        {
            //pickup is out of bounds, so respawn it to the top of the screen
            x = Random.Range(-4, 4);
            y = Random.Range(5, 10);
            pos = new Vector3(x, y);
            pickupScript.transform.position = pos;
        }

        else if(obstaclesScript)
        {
            //obstacle is out of bounds, so respawn it to the top of the screen
            x = Random.Range(-4, 4);
            y = Random.Range(5, 10);
            pos = new Vector3(x, y);
            obstaclesScript.transform.position = pos;
        }
    }

}
