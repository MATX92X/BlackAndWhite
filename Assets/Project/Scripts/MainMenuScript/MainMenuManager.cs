using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public string nameLevel;

    public void NewGame()
    {
        SceneManager.LoadScene(nameLevel);
    }

    public void OptionMenu()
    {
        //menu opzioni da aggiungere
        print("null");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}