using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour
{

    //Variabili
    public float speed;
    public float jump;
    public float stopCameraDistance;
    private float currSpeed;

    //checker
    public Transform groundChecker1;
    public Transform groundChecker2;
    private bool grounded = true;

    public Transform edgeChecker;
    public float edgeCheckRadius;
    private bool atEdge;

    public Transform wallChecker1;
    public Transform wallChecker2;
    private bool atWall;

    //camera
    private Transform cameraTransform;

    void Awake()
    {
        cameraTransform = FindObjectOfType<Camera>().transform;
    }


    void Update()
    {
        //modify speed value in relation of the cameras position
        if ((transform.position.x - cameraTransform.position.x) > stopCameraDistance)
            currSpeed = speed * 0.45f;
        if ((transform.position.x - cameraTransform.position.x) < -stopCameraDistance)
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, jump); //try to unstuck the player with a jump
        else if ((transform.position.x - cameraTransform.position.x) < 0)
            currSpeed = speed * 0.8f;

        //set the speed
        GetComponent<Rigidbody2D>().velocity = new Vector2(currSpeed, GetComponent<Rigidbody2D>().velocity.y);

        //check the checker
        grounded = Physics2D.OverlapArea(groundChecker1.position, groundChecker2.position);
        atEdge = !Physics2D.OverlapCircle(edgeChecker.position, edgeCheckRadius);
        atWall = Physics2D.OverlapArea(wallChecker1.position, wallChecker2.position);

        if (grounded)
            if (atEdge || atWall) GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
    }
}

