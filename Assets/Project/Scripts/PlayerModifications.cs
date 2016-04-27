using UnityEngine;
using System.Collections;

public class PlayerModifications : MonoBehaviour
{
    //Tag
    public string GoodTag;
    public string BadTag;

    //Modificazioni
    public float ContinueDecrease;
    public float GoodIncrease;
    public float BadIncrease;

    //legate al pause menu
    public PausedMenuBehavior pauseMenu;

    //GoodIncrease
    void OnTriggerEnter2D(Collider2D other)
    {
        //Verifico che il trigger sia di un oggetto con Tag == GoodFood
        if (other.gameObject.tag == GoodTag)
        {
            //Aumento di dimensioni solo in x&y z resta costante
            transform.localScale += new Vector3(GoodIncrease, GoodIncrease, 0);
            Destroy(other.gameObject);
        }
        //Verifico che il trigger sia di un oggetto con Tag == BadFood
        if (other.gameObject.tag == BadTag)
        {
            //Aumento di dimensioni solo in x&y z resta costante
            transform.localScale += new Vector3(BadIncrease, BadIncrease, 0);
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        //controllo della dimensione minima e se non nel pause menu
        if ((transform.localScale.x >= 0.4) && !pauseMenu.isPaused)
        {
            //Dimagrimento continuo
            transform.localScale -= new Vector3(ContinueDecrease, ContinueDecrease, 0);
        }
    }
}
