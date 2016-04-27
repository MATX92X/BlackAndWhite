using UnityEngine;
using System.Collections;

public class CameraMovementMainMenu : MonoBehaviour {

    public float xMovement, yMovement;

	void Update ()
    {
        //ad ogni frame sposta la telecamera di un tot
        transform.position = new Vector3(transform.position.x + xMovement,
                                         transform.position.y + yMovement,
                                         transform.position.z);
    }
}
