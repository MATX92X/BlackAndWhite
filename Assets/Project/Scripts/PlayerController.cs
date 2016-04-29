using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    //Variabili
    public float speed;
    public float jump;
	public static float distTraveled;
    float moveVelocity;

    bool grounded = true;
     
    // Update is called once per frame
    void Update()
    {
        //Fermo l'oggetto
        moveVelocity = 0;
        
        //Left&Right movement
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            moveVelocity = speed;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            moveVelocity = -speed;

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        //jump
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
            }
        }
		distTraveled = transform.localPosition.x;
    }

    //check if grounded
    void OnTriggerEnter2D()
    {
        grounded = true;
    }
    void OnTriggerExit2D()
    {
        grounded = false;
    }
}