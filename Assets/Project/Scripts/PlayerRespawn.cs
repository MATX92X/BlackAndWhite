using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour {

    //Spawn vars
    bool respawn = false;
    public GameObject spawnObject;
    public GameObject mainCamera;
    public GameObject cameraSpawn;
    public string menuName;

    // Update is called once per frame
    void Update () {
        //controllo che non diventi troppo piccolo il personaggio
        if ((transform.localScale.x) > 0.4 && (transform.localScale.x < 0.5) )
        {
            respawn = true;
        }
        else
        {
            respawn = false;
        }

        //Se raggiungo il limite riporto il Player al punto di partenza con le dimensioni di partenza
        if (respawn)
        {
            /*transform.localPosition = spawnObject.transform.localPosition;
            transform.localScale = spawnObject.transform.localScale;
            mainCamera.transform.localPosition = cameraSpawn.transform.localPosition;*/
			SceneManager.LoadScene(menuName);
        }
    }
}
