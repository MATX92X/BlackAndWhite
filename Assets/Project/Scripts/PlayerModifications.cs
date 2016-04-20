using UnityEngine;
using System.Collections;

public class PlayerModifications : MonoBehaviour
{
    public string Tag;
    public float ContinueDecrease;
    public float GoodIncrease;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == Tag)
        {
            transform.localScale += new Vector3(GoodIncrease, GoodIncrease, 0);
            Destroy(other.gameObject);
        }
    }

	// Update is called once per frame
	void Update ()
    {
        if ((transform.localScale.x) > 0.5)
        {
            //Dimagrimento continuo
            transform.localScale -= new Vector3(ContinueDecrease, ContinueDecrease, 0);
        }

    }
}
