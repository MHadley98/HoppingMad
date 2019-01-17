using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    public Rigidbody2D physicsBody;

    //variable to let us add to score
    //public so we can drag and drop
    public Score scoreObject;

    //variable to hold pickup's point value
    //public so we can edit in editor
    public int pickupValue;

    //variables to be used to store each objects position
    float x;
    float y;
    Vector3 pos;

    // Use this for initialization
    void Start () {
        //Generates a random position to spawn the objects at
        x = Random.Range(-4, 4);
        y = Random.Range(5, 10);
        pos = new Vector3(x, y);
        transform.position = pos;
    }
	
	// Update is called once per frame
	void Update () {
        //generates a random position to spawn objects at for when they reach the bottom of the screen
        x = Random.Range(-4, 4);
        y = Random.Range(5, 10);
        pos = new Vector3(x, y);
    }

    

    //unity calls pickup this function when pickup touches an other obeject
    //if the player touches the pickup should disappesr and score should go up
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if what we touched is the player
        Player playerScript = collision.collider.GetComponent<Player>();

        //if the thing touched has player script, means it is player so...
        if (playerScript)
        {
            //we hit the player

            //add to score based on pickup value
            scoreObject.AddScore(pickupValue);

            //sends touched object to the position generated in update function
            transform.position = pos;
        }
    }
}

