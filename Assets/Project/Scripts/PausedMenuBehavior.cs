using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PausedMenuBehavior : MonoBehaviour {

    public bool isPaused;
    public GameObject menuCanvas;

    void Update()
    {
        //se in pausa attiva il canvas del menu e rallenta la velocità del gioco a zero
        if (isPaused)
        {
            menuCanvas.SetActive(true);
            Time.timeScale = 0f;
        } else {
            menuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))   isPaused = !isPaused;

    }

    public void ResumeGame ()
    {
        isPaused = false;
    }

    public void QuitToMainMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
