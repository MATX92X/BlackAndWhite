using UnityEngine;
using System.Collections;

public class FoodManager: MonoBehaviour
{
    public GameObject GoodFood;
    public float Speed;
    public Camera MainCamera;

    void Start()
    {
        //Funzione continua per generare cibo a velocità Speed
        InvokeRepeating("GenerateGood", 0, Speed);
    }

    void GenerateGood()
    {
        //Creo nella metà inferiore dello schermo il cibo
        int x = Random.Range(0, Camera.main.pixelWidth);
        int y = Random.Range(0, (Camera.main.pixelHeight) / 2);
        /*
                Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));
                Target.z = 0;
        */
        Vector3 Target = new Vector3((MainCamera.transform.position.x + x), y, 0);
        Instantiate(GoodFood, Target, Quaternion.identity);
    }
}
