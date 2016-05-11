using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PausedMenuBehavior : MonoBehaviour {

    public bool isPaused;
    public GameObject menuCanvas;
    public string menuName;

    private bool isQuitting;

    void Awake()
    {
        isQuitting = false;
    }

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

        //se il pulsante quit è premuto setta la timeScale a 1f e carica la schermata iniziale
        if (isQuitting)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(menuName);
        }

        if ( Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P) )   isPaused = !isPaused;

    }

    public void ResumeGame ()
    {
        isPaused = false;
    }

    public void QuitToMainMenu ()
    {
        isQuitting = true;
    }

}
