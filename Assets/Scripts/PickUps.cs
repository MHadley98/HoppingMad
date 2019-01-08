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

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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

            //destroy the gameObject that script is attached to(pickup)
            Destroy(gameObject);
        }
    }
}

