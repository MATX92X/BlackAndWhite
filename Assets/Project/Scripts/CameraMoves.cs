using UnityEngine;
using System.Collections;

public class CameraMoves : MonoBehaviour {

    float speed;
    float moveVelocity;
	
	// Update is called once per frame
	void Update ()
    {
        //Spostamento automatico telecamera
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 4;
            moveVelocity = speed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
